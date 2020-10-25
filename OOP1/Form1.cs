using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP1
{
    public partial class Form1 : Form
    {
        int Rows = 100;
        int Columns = 100;
        Dictionary<int, List<Cell>> RowsInfo = new Dictionary<int, List<Cell>>();
        Dictionary<int, List<Cell>> ColumnsInfo = new Dictionary<int, List<Cell>>();
        Cell currentCell = null;
        Parser parser = new Parser();
        CellNameUtil dependencies = new CellNameUtil();
        Dictionary<string, Cell> dictionary = new Dictionary<string, Cell>();
        Indexator indexator = new Indexator();
        List<string> needed = new List<string> ();
        public Form1()
        {
            this.InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                AddColumn(i);
                AddRow(i);
            }


        }

        private void Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (currentCell != null)
            {
                if (TextBox.Text != "")
                {
                    TextBox.Text = TextBox.Text + " " + ((char)(e.ColumnIndex + 65)).ToString() + e.RowIndex.ToString();
                }
                else
                {
                    TextBox.Text = ((char)(e.ColumnIndex + 65)).ToString() + e.RowIndex.ToString();
                }
            }
            else
            {

                currentCell = Data[e.ColumnIndex, e.RowIndex] as Cell;
                Current.Text = ((char)(e.ColumnIndex + 65)).ToString() + e.RowIndex.ToString();
                currentCell.name = Current.Text;
                currentCell.rowNumber = e.RowIndex;
                currentCell.colNumber = e.ColumnIndex;
                TextBox.Text = currentCell.exp;
                if (!dictionary.ContainsKey(Current.Text))
                {
                    dictionary.Add(Current.Text, currentCell);
                }
                TextBox.Enabled = true;
            }
            TextBox.Focus();
        }

        
        double CalculateCell(Cell c, DataGridView dgv)
        {
           
            string saveFormula = c.exp;
            List<string> anotherCells = dependencies.ListOfCells(c);
            
            foreach (string cell in anotherCells)
            {
                needed.Add(cell);
                if (cell == currentCell.Name)
                {
                    currentCell.value = -1;
                    currentCell.exp = "";
                    throw (new Exception("recursive"));
                }
            }
            if (anotherCells.Count == 0)
            {
                
                double result = c != currentCell ? parser.Evaluate(c.Value.ToString()) : parser.Evaluate(c.exp);
                return result != 0 ? 1d : 0d;
            }
            else
            {
                for (int i = 0; i < anotherCells.Count; i++)
                {
                    int row = 0, col = 0 ;
                    foreach( char ca  in anotherCells[i].ToCharArray())
                    {
                        if (ca <= '9' && ca >= '0')
                        {
                            row *= 10;
                            row += ca - '0';
                        } else
                        {
                            col *= 26;
                            col += ca - 'A';
                        }
                    }
                    if (!RowsInfo[row].Contains(c) && row != c.rowNumber)
                    {
                        RowsInfo[row].Add(c);
                    }
                    if (!ColumnsInfo[col].Contains(c) && row != c.colNumber)
                    {
                        ColumnsInfo[col].Add(c);
                    }
                    if (dictionary.ContainsKey(anotherCells[i]))
                    {
                        c.exp = c.exp.Replace(anotherCells[i], " " + CalculateCell(dictionary[anotherCells[i]], dgv).ToString() + " ");
                    }
                    else
                    {
                        c.exp = c.exp.Replace(anotherCells[i], " 0 ");
                    }
                }
                string finishFormula = c.exp;
                c.exp = saveFormula;
                return parser.Evaluate(finishFormula);
            }
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (currentCell != null)
                {
                    try
                    {
                        currentCell.exp = TextBox.Text;
                        currentCell.value = CalculateCell(currentCell, Data);
                        Console.WriteLine(currentCell.value);
                        if (currentCell.value != 0)
                        {
                            currentCell.Style.BackColor = Color.Green;
                        }
                        else
                        {
                            currentCell.Style.BackColor = Color.Red;

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        currentCell.Style.BackColor = Color.White;
                    }
                    ResetCell();
                }
                
            }
        }
        void ResetCell()
        {
            currentCell = null;
            Current.Text = "";
            TextBox.Text = "";
            TextBox.Enabled = false;
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            ResetCell();
        }


        private void DeleteRow_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DeleteRowTextBox.Text) >= 0 && Convert.ToInt32(DeleteRowTextBox.Text) < Rows)
            {
                DeleteRows(Convert.ToInt32(DeleteRowTextBox.Text));
            }
             
        }

        private void DeleteRows(int number)
        {
            RowsInfo[number].ForEach((Cell cell) =>
            {
                cell.exp = "";
                cell.value = -1;
                cell.Style.BackColor = Color.White;
               
            });
            Rows--;
            Data.Rows.RemoveAt(number);
        }

        private void DeleteColumn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DeleteColumnTextBox.Text) >= 0 && Convert.ToInt32(DeleteColumnTextBox.Text) < Columns)
            {
                DeleteColumns(Convert.ToInt32(DeleteColumnTextBox.Text));
            }
        }
        private void DeleteColumns(int number)
        {
            Console.WriteLine(number);
            ColumnsInfo[number].ForEach((Cell cell) =>
            {
                cell.exp = "";
                cell.value = -1;
                cell.Style.BackColor = Color.White;
                
            });
            Columns--;
            Data.Columns.RemoveAt(number);
        }
        private void AddColumn(int i)
        {
            DataGridViewColumn column;
            column = new DataGridViewColumn();
            int a = i;
            while (a / 26 > 0)
            {
                column.HeaderText += ((char)((a / 26) + 64)).ToString();
                a %= 26;
            }
            column.HeaderText += ((char)(a + 65)).ToString();
            column.Name = ((char)(i + 65)).ToString();
            column.CellTemplate = new Cell(column.HeaderText, i.ToString());
            Data.Columns.Add(column);
            ColumnsInfo.Add(i, new List<Cell>());
        }
        private void AddRow(int i)
        {
            Data.Rows.Add();
            RowsInfo.Add(i, new List<Cell>());
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            AddRow(Rows);
            Rows++;
        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            AddColumn(Columns);
            Columns++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("    Are you sure close table?", "Message", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Stream mystr;
            if (saveFileDialog3.ShowDialog() == DialogResult.OK)
            {
                if ((mystr = saveFileDialog3.OpenFile()) != null)
                {
                    StreamWriter sw = new StreamWriter(mystr);
                    try
                    {
                        for (int i = 0; i < Data.RowCount; i++)
                        {
                            for (int j = 0; j < Data.ColumnCount; j++)
                            {
                                string currCellName = indexator.NumberToLetter(j + 1) + (i + 1).ToString();
                                if (!dictionary.ContainsKey(currCellName))
                                {
                                    Cell cell = new Cell();
                                    cell.Value = -1;
                                    dictionary.Add(currCellName, cell);
                                }
                                if (dictionary[currCellName].exp != null)
                                {
                                    sw.Write(dictionary[currCellName].exp + '$');

                                }

                            }
                            sw.WriteLine("");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    sw.Close();
                    mystr.Close();
                }
            }
        
    }

        private void saveFileDialog3_FileOk(object sender, CancelEventArgs e)
        {

        }

        
                
            
        
    }
}
