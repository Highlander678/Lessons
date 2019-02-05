using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ТектовоеПолеВводДанных
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double X))
            {
                label1.Text = Convert.ToString(Math.Sqrt(double.Parse(textBox1.Text)));
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Необходимо вводить только числа";
            }

            
        }
    }
}
