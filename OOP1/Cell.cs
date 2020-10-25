using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Cell : System.Windows.Forms.DataGridViewTextBoxCell
    {
        public string name;
        public double value;
        public string exp;
        public int rowNumber;
        public int colNumber;
        public Cell(string Vertiacal, string Horizontal)
        {
            name = Vertiacal + Horizontal;
            exp = "";
            value = -1;
        }
        public Cell()
        {
            name = "A1";
            exp = "";
            value = -1;
        }
        public string Name
        {
            get { return name; }
            set { Name = value; }
        }
        new public double Value
        {
            get { return value; }
            set { Value = value; }
        }
        
    }
}
