﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_4
{
    public partial class Form1 : Form
    {
        private List<Triangle> triangles = new List<Triangle>() { };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            triangles.ForEach(triangle => triangle.getFullInfo());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);

                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                Triangle triangle = new Triangle(a, b, c);
                triangles.Add(triangle);
                Console.WriteLine("Done");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch
            {
                Console.WriteLine("Enter smth into textBoxes pls");
            }
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox4.Text);
                triangles.Add(new EquilateralTriangle(a));
                Console.WriteLine("Done");
                textBox4.Clear();
            }
            catch
            {
                Console.WriteLine("Enter smth into textBoxes pls");
            }
        }
    }
}
