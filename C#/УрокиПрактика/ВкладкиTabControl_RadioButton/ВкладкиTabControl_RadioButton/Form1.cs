using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ВкладкиTabControl_RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = " Вкладки TabControl и переключатели RadioButton";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Выберите Текст, Цвет, Размер";
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold",
                                    9F,
                                    System.Drawing.FontStyle.Regular,
                                    System.Drawing.GraphicsUnit.Point,
                                    ((byte)(0)));
            label1.ForeColor = Color.Black;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, 12);
            
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, 25);
        }
    }
}
