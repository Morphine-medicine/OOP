using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Lab2
{
    interface IAnalizatorXml
    {
        List<Employee> filterEmployees(Employee employee);
    }
    partial class AnalizatorDOM : IAnalizatorXml
    {
        public List<Employee> filterEmployees(Employee employee)
        {
            List<Employee> result = new List<Employee>();

            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Dell\source\repos\Lab2\XMLEmployees.xml");

            XmlElement xmlElem = doc.DocumentElement;
            foreach(XmlNode nod in xmlElem.ChildNodes)
            {

                string Office = "";

                foreach(XmlAttribute attribut in nod.Attributes)
                {

                    if (attribut.Name.Equals("OFFICE") && (attribut.Value.Equals(employee.office) || employee.office.Length == 0))
                    {
                        Office = attribut.Value;
                        foreach(XmlNode node in nod.ChildNodes)
                        {
                            string Name = "";
                            string Sex = "";
                            string Position = "";
                            string Status = "";
                            string Experience = "";
                            foreach (XmlAttribute attribute in node.Attributes)
                            {
                                if (attribute.Name.Equals("Name") && (attribute.Value.Equals(employee.name) || employee.name.Length == 0))
                                {
                                    Name = attribute.Value;
                                }
                                if (attribute.Name.Equals("Sex") && (attribute.Value.Equals(employee.sex) || employee.sex.Length == 0))
                                {
                                    Sex = attribute.Value;
                                }
                                if (attribute.Name.Equals("Position") && (attribute.Value.Equals(employee.position) || employee.position.Length == 0))
                                {
                                    Position = attribute.Value;
                                }
                                if (attribute.Name.Equals("Status") && (attribute.Value.Equals(employee.status) || employee.status.Length == 0))
                                {
                                    Status = attribute.Value;
                                }
                                if (attribute.Name.Equals("Experience") && (attribute.Value.Equals(employee.experience) || employee.experience.Length == 0))
                                {
                                    Experience = attribute.Value;
                                }
                            }
                            if (Name != "" && Sex != "" && Position != "" && Status != "" && Office != "" && Experience != "")
                            {
                                Employee employeeResult = new Employee();
                                employeeResult.name = Name;
                                employeeResult.office = Office;
                                employeeResult.position = Position;
                                employeeResult.sex = Sex;
                                employeeResult.status = Status;
                                employeeResult.experience = Experience;
                                result.Add(employeeResult);
                            }
                        }
                    }


                }
            }

            return result;
        }
    }
    partial class AnalizatorSAX : IAnalizatorXml
    {
        public List<Employee> filterEmployees(Employee employee)
        {
            List<Employee> result = new List<Employee>();
            var reader = new XmlTextReader(@"C:\Users\Dell\source\repos\Lab2\XMLEmployees.xml");
            string Office = "";
            while (reader.Read())
            {

                
                if (reader.Name == "Office")
                {
                    if (reader.HasAttributes)
                    {
                        reader.MoveToNextAttribute();
                        if (reader.Name.Equals("OFFICE") && (reader.Value.Equals(employee.office) || employee.office.Length == 0))
                        {
                            Office = reader.Value;
                        }
                    }
                    if (reader.NodeType == XmlNodeType.EndElement)
                    {
                        Office = "";
                    }
                }
                if (reader.Name == "Employee")
                {
                    
                    if (reader.HasAttributes)
                    {

                        string Name = "";
                        string Experience = "";
                        string Status = "";
                        string Sex = "";
                        string Position = "";
                        while (reader.MoveToNextAttribute())
                        {
                            if (reader.Name.Equals("Name") && (reader.Value.Equals(employee.name) || employee.name.Length == 0))
                            {
                                Name = reader.Value;
                            }
                            if (reader.Name.Equals("Experience") && (reader.Value.Equals(employee.experience) || employee.experience.Length == 0))
                            {
                                Experience = reader.Value;
                            }
                            if (reader.Name.Equals("Status") && (reader.Value.Equals(employee.status) || employee.status.Length == 0))
                            {
                                Status = reader.Value;
                            }
                            if (reader.Name.Equals("Sex") && (reader.Value.Equals(employee.sex) || employee.sex.Length == 0))
                            {
                                Sex = reader.Value;
                            }
                            if (reader.Name.Equals("Position") && (reader.Value.Equals(employee.position) || employee.position.Length == 0))
                            {
                                Position = reader.Value;
                            }
                            if (Name != "" && Sex != "" && Position != "" && Status != "" && Office != "" && Experience != "")
                            {
                                Employee employeeResult = new Employee();
                                employeeResult.name = Name;
                                employeeResult.office = Office;
                                employeeResult.position = Position;
                                employeeResult.sex = Sex;
                                employeeResult.status = Status;
                                employeeResult.experience = Experience;
                                result.Add(employeeResult);
                            }

                        }

                    }
                }
            }
            reader.Close();
            return result;
        }
    }
    partial class AnalizatorLINQtoXML : IAnalizatorXml
    {
        public List<Employee> filterEmployees(Employee employee)
        {
            List<Employee> result = new List<Employee>();
            var doc = XDocument.Load(@"C:\Users\Dell\source\repos\Lab2\XMLEmployees.xml");
            var employees = from obj in doc.Descendants("Employee")
                            where
                            (
                            (obj.Attribute("Name").Value.Equals(employee.name) || (employee.name.Length == 0)) &&
                            (obj.Attribute("Sex").Value.Equals(employee.sex) || (employee.sex.Length == 0)) &&
                            (obj.Attribute("Position").Value.Equals(employee.position) || (employee.position.Length == 0)) &&
                            (obj.Parent.Attribute("OFFICE").Value.Equals(employee.office) || (employee.office.Length == 0)) &&
                            (obj.Attribute("Status").Value.Equals(employee.status) || (employee.status.Length == 0)) &&
                            (obj.Attribute("Experience").Value.Equals(employee.experience) || (employee.experience.Length == 0))
                            )
                            select new
                            {
                                name = (string)obj.Attribute("Name"),
                                sex = (string)obj.Attribute("Sex"),
                                position = (string)obj.Attribute("Position"),
                                experience = (string)obj.Attribute("Experience"),
                                status = (string)obj.Attribute("Status"),
                                office = (string)obj.Parent.Attribute("OFFICE")
                            };
            foreach (var currentEmployee in employees)
            {
                Employee resultEmployee = new Employee();
                resultEmployee.name = currentEmployee.name;
                resultEmployee.sex = currentEmployee.sex;
                resultEmployee.position = currentEmployee.position;
                resultEmployee.experience = currentEmployee.experience;
                resultEmployee.status = currentEmployee.status;
                resultEmployee.office = currentEmployee.office;
                result.Add(resultEmployee);
            }

            return result;
        }
    }

}
