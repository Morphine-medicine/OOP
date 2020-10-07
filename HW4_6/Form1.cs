using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_6
{
    public partial class Form1 : Form
    {
        private List<Triangle> triangles = new List<Triangle>() { };
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                triangles.Add(new RightTriangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
                textBox1.Clear();
                textBox2.Clear();
                Console.WriteLine("Done!");
            }
            catch
            {
                Console.WriteLine("Not enough params");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                triangles.Add(new IsoscelesTriangle(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox3.Text)));
                textBox3.Clear();
                textBox4.Clear();
                Console.WriteLine("Done!");
            }
            catch
            {
                Console.WriteLine("Not enough params");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            triangles.ForEach(triangle => triangle.getTriangleInfo());
        }
    }
}
