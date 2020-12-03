using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace Lab2
{
    public partial class XmlAnalizator : Form
    {
        List<Employee> chosenEmployees = new List<Employee>();
        public XmlAnalizator()
        {
            InitializeComponent();
            GetEmployeeList();
        }
        public void GetEmployeeList()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Dell\source\repos\Lab2\XMLEmployees.xml");

            XmlElement xmlElem = doc.DocumentElement;
            XmlNodeList xmlNodeList = xmlElem.SelectNodes("Office");

            foreach (XmlNode office in xmlNodeList)
            {
                addEmployeesInfo(office);
            }
            filter();
        }
        private void addEmployeesInfo(XmlNode office)
        {
            if (!OfficeComboBox.Items.Contains(office.SelectSingleNode("@OFFICE").Value))
            {
                OfficeComboBox.Items.Add(office.SelectSingleNode("@OFFICE").Value);
            }
            XmlNodeList xmlNodeList = office.SelectNodes("Employee");
            foreach (XmlNode employee in xmlNodeList)
            {
                addEmployeeInfo(employee);
            }

        }
        private void addEmployeeInfo (XmlNode employee)
        {
            if (!NameComboBox.Items.Contains(employee.SelectSingleNode("@Name").Value))
            {
                NameComboBox.Items.Add(employee.SelectSingleNode("@Name").Value);
            }
            if (!SexComboBox.Items.Contains(employee.SelectSingleNode("@Sex").Value))
            {
                SexComboBox.Items.Add(employee.SelectSingleNode("@Sex").Value);
            }
            if (!StatusComboBox.Items.Contains(employee.SelectSingleNode("@Status").Value))
            {
                StatusComboBox.Items.Add(employee.SelectSingleNode("@Status").Value);
            }
            if (!PositionComboBox.Items.Contains(employee.SelectSingleNode("@Position").Value))
            {
                PositionComboBox.Items.Add(employee.SelectSingleNode("@Position").Value);
            }
            if (!ExperienceComboBox.Items.Contains(employee.SelectSingleNode("@Experience").Value))
            {
                ExperienceComboBox.Items.Add(employee.SelectSingleNode("@Experience").Value);
            }
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            filter();
        }

        private void filter()
        {
            EmployeesList.Text = "";
            Employee employee = new Employee();
            if (NameCheckBox.Checked)
            {
                employee.name = NameComboBox.SelectedItem.ToString();
            }
            if (SexCheckBox.Checked)
            {
                employee.sex = SexComboBox.SelectedItem.ToString();
            }
            if (ExperienceCheckBox.Checked)
            {
                employee.experience = ExperienceComboBox.SelectedItem.ToString();
            }
            if (PositionCheckBox.Checked)
            {
                employee.position = PositionComboBox.SelectedItem.ToString();
            }
            if (StatusCheckBox.Checked)
            {
                employee.status = StatusComboBox.SelectedItem.ToString();
            }
            if (OfficeCheckBox.Checked)
            {
                employee.office = OfficeComboBox.SelectedItem.ToString();
            }

            IAnalizatorXml analizatorXml = new AnalizatorDOM();
            if (SAX.Checked)
            {
                analizatorXml = new AnalizatorSAX();
            }
            if (LINQtoXML.Checked)
            {
                analizatorXml = new AnalizatorLINQtoXML();
            }
            List<Employee> employees = analizatorXml.filterEmployees(employee);
            chosenEmployees = employees;

            foreach (Employee employee1 in employees)
            {
                EmployeesList.Text += "Name: " + employee1.name + "\n";
                EmployeesList.Text += "Sex: " + employee1.sex + "\n";
                EmployeesList.Text += "Experience: " + employee1.experience + "\n";
                EmployeesList.Text += "Office: " + employee1.office + "\n";
                EmployeesList.Text += "Status: " + employee1.status + "\n";
                EmployeesList.Text += "Position: " + employee1.position + "\n";

                EmployeesList.Text += "\n\n\n";
            }


        }

        private void Clear_Click(object sender, EventArgs e)
        {
            EmployeesList.Text = "";
            NameCheckBox.Checked = false;
            NameComboBox.SelectedItem = null;
            SexCheckBox.Checked = false;
            SexComboBox.SelectedItem = null;
            PositionCheckBox.Checked = false;
            PositionComboBox.SelectedItem = null;
            OfficeCheckBox.Checked = false;
            OfficeComboBox.SelectedItem = null;
            ExperienceCheckBox.Checked = false;
            ExperienceComboBox.SelectedItem = null;
            StatusCheckBox.Checked = false;
            StatusComboBox.SelectedItem = null;
            DOM.Checked = true;
        }

        private void Transform_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
            xslCompiledTransform.Load(@"C:\Users\Dell\source\repos\Lab2\XMLEmployees.xst");
            string fXML = @"C:\Users\Dell\source\repos\Lab2\XMLEmployees.xml";
            string fHTML = @"C:\Users\Dell\source\repos\Lab2\XMLEmployees.html";
            xslCompiledTransform.Transform(fXML, fHTML);
        }

        private void XmlAnalizator_FormClosing(object sender, FormClosingEventArgs e)
        {
            var closeMsg = MessageBox.Show("Do you really want to close?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (closeMsg == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private XmlNode createEmployeeNode(Employee employee)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Dell\source\repos\Lab2\XMLChosenEmployees.xml");
            

            XmlNode employeeNode = doc.CreateNode(XmlNodeType.Element, "Employee", "");
            XmlAttribute attribute = doc.CreateAttribute("Name");
            employeeNode.Attributes.Append(attribute);
            attribute = doc.CreateAttribute("Experience");
            employeeNode.Attributes.Append(attribute);
            attribute = doc.CreateAttribute("Sex");
            employeeNode.Attributes.Append(attribute);
            attribute = doc.CreateAttribute("Status");
            employeeNode.Attributes.Append(attribute);
            attribute = doc.CreateAttribute("Position");
            employeeNode.Attributes.Append(attribute);

            employeeNode.Attributes["Name"].Value = employee.name;
            employeeNode.Attributes["Experience"].Value = employee.experience;
            employeeNode.Attributes["Sex"].Value = employee.sex;
            employeeNode.Attributes["Status"].Value = employee.status;
            employeeNode.Attributes["Position"].Value = employee.position;

            return employeeNode.OwnerDocument.ImportNode(employeeNode, true);
        }

        private XmlNode createOfficeNode(XmlNode office)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Dell\source\repos\Lab2\XMLChosenEmployees.xml");

            XmlNode result = office.Clone();
            return result.OwnerDocument.ImportNode(result, true);
        }
        private void ClearChosenXml()
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Dell\source\repos\Lab2\XMLChosenEmployees.xml");
            XmlElement xmlElem = doc.DocumentElement;
            xmlElem.RemoveAll();
            doc.Save(@"C:\Users\Dell\source\repos\Lab2\XMLChosenEmployees.xml");
        }
        private void TransformSelectedEmployeeXml()
        {
            string office = chosenEmployees[0].office;
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Dell\source\repos\Lab2\XMLChosenEmployees.xml");
            XmlElement xmlElem = doc.DocumentElement;
            XmlNode officeNode = doc.CreateNode(XmlNodeType.Element, "Office", "");
            XmlAttribute attribute = doc.CreateAttribute("OFFICE");
            officeNode.Attributes.Append(attribute);
            XmlNode xmlNode = null;
            officeNode.Attributes["OFFICE"].Value = office;
            foreach (Employee employee in chosenEmployees)
            {
                if (office != employee.office)
                {
                    xmlNode = xmlElem.OwnerDocument.ImportNode(createOfficeNode(officeNode), true);
                    xmlElem.AppendChild(xmlNode);
                    office = employee.office;
                    officeNode.RemoveAll();
                    attribute = doc.CreateAttribute("OFFICE");
                    officeNode.Attributes.Append(attribute);
                    officeNode.Attributes["OFFICE"].Value = office;
                    
                }
                xmlNode = officeNode.OwnerDocument.ImportNode(createEmployeeNode(employee), true);
                
                officeNode.AppendChild(xmlNode);

            }
            xmlNode = xmlElem.OwnerDocument.ImportNode(createOfficeNode(officeNode), true);
            xmlElem.AppendChild(xmlNode);
            doc.Save(@"C:\Users\Dell\source\repos\Lab2\XMLChosenEmployees.xml");
        }
        private void TransformCurrent_Click(object sender, EventArgs e)
        {
            if (chosenEmployees.Count == 0)
            {
                MessageBox.Show("There are no employees, nothing to transform");
            } else
            {
                TransformSelectedEmployeeXml();
                XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
                xslCompiledTransform.Load(@"C:\Users\Dell\source\repos\Lab2\XMLEmployees.xst");
                string fXML = @"C:\Users\Dell\source\repos\Lab2\XMLChosenEmployees.xml";
                string fHTML = @"C:\Users\Dell\source\repos\Lab2\XMLEmployees.html";
                xslCompiledTransform.Transform(fXML, fHTML);
                ClearChosenXml();
            }
        }
    }
}
