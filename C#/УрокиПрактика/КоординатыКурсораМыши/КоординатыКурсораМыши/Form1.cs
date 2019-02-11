using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КоординатыКурсораМыши
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Text = null;
            label1.Text = null;
            label2.Text = null;
        }

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
            listBox1.Items.Add("Мышь находится над элементом listBox1");
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            listBox1.Items.Add("Мышь покинула ListBox1");
            
            
        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = string.Format("X = {0}", e.X);
            label2.Text = string.Format("Y = {0}", e.Y);
        }
    }
}
