using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseHover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Новая форма";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Equals = System.Windows.Forms.FormStartPosition.CenterScreen;
            MessageBox.Show("Hellow World");
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Мышь над текстом");
        }
    }
}
