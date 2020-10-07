using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_5
{
    public partial class Form1 : Form
    {
        private List<Figure> figures = new List<Figure>() { };
        public Form1()
        {
            InitializeComponent();
        }

        private void AddTriangleButton_Click(object sender, EventArgs e)
        {
            try
            {
                figures.Add(new Triangle(Convert.ToDouble(TriangleA.Text), Convert.ToDouble(TriangleB.Text), Convert.ToDouble(TriangleC.Text)));
                Console.WriteLine("Done!");
                TriangleA.Clear();
                TriangleB.Clear();
                TriangleC.Clear();
            }
            catch
            {
                Console.WriteLine("Oops, not enough params");
            }
        }

        private void AddCircleButto_Click(object sender, EventArgs e)
        {
            
            try
            {
                figures.Add(new Circle(Convert.ToDouble(CIrcleR.Text)));
                Console.WriteLine("Done!");
                CIrcleR.Clear();
            }
            catch
            {
                Console.WriteLine("Oops, not enough params");
            }
        }

        private void AddRectangleButto_Click(object sender, EventArgs e)
        {
            try
            {
                figures.Add(new Rectangle(Convert.ToDouble(RectangleA.Text), Convert.ToDouble(RectangleB.Text)));
                Console.WriteLine("Done!");
                RectangleA.Clear();
                RectangleB.Clear();
            }
            catch
            {
                Console.WriteLine("Oops, not enough params");
            }
            
        }

        private void AddRhombusButton_Click(object sender, EventArgs e)
        {
            try
            {
                figures.Add(new Rhombus(Convert.ToDouble(RhombusD1.Text), Convert.ToDouble(RhombusD2.Text)));
                Console.WriteLine("Done!");
                RhombusD1.Clear();
                RhombusD2.Clear();
            }
            catch
            {
                Console.WriteLine("Oops, not enough params");
            }
        }

        private void AddSquareButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                figures.Add(new Square(Convert.ToDouble(SquareA.Text)));
                Console.WriteLine("Done!");
                SquareA.Clear();
            }
            catch
            {
                Console.WriteLine("Oops, not enough params");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            figures.ForEach(figure => figure.printFigureInfo());
        }
    }
}
