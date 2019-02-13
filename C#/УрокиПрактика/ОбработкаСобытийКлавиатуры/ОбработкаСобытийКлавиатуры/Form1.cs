using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОбработкаСобытийКлавиатуры
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //label1.Text = string.Format("{0}",e.KeyChar);
            label2.Text += e.KeyChar;        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Нажата клавиша: ";
            label3.Text = "Зажата клавиша: ";
            label2.Text = string.Empty;
            label4.Text = string.Empty;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Alt) label4.Text = "Alt";
            if (e.Control) label4.Text = "Control";
            if (e.Shift) label4.Text = "Shift";
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label2.Text = string.Empty;
            label4.Text = string.Empty;
        }
    }
}
