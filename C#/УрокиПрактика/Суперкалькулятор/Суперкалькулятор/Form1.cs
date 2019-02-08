using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Суперкалькулятор
{
    public partial class Form1 : Form
    {
        NumberFormatInfo numberformtinfo = new NumberFormatInfo()
        {

            NumberDecimalSeparator = "."


        };
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text;

            if (!double.TryParse(textBox1.Text, out double X))
            {
                X = double.Parse(textBox1.Text, numberformtinfo);
                MessageBox.Show("Следует вводить только числа", "Ошибка первого поля",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!double.TryParse(textBox2.Text, out double Y))
            {
                Y = double.Parse(textBox2.Text, numberformtinfo);
                MessageBox.Show("Следует вводить только числа", "Ошибка второго поля",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (double.TryParse(textBox2.Text, out Y))
                if (Y == 0) MessageBox.Show("Ошибка деление на ноль",
                      "Деление на ноль", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            switch (comboBox1.Text)
            {
                case "Сложение":
                    label1.Text = Convert.ToString(X + Y); break;
                case "Вычитание":
                    label1.Text = Convert.ToString(X - Y); break;
                case "Умножение":
                    label1.Text = Convert.ToString(X * Y); break;
                case "Деление":
                    label1.Text = Convert.ToString(X / Y); break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Выберите арифм. операцию";
            string[] Операции = { "Сложение", "Вычитание", "Умножение", "Деление" };
            comboBox1.Items.AddRange(Операции);
            // label2.Text = String.Format("Найдем длину окружности: \n" +
            //" {0} = 2{1}{2}{1}R, \n" + "где {2} = {3}",
            //Convert.ToChar(0x3B2), Convert.ToChar(0x2219),
            //Convert.ToChar(0x3C0), Math.PI);
            label2.Text = string.Format("{0}",Convert.ToChar(0x3B2));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }
    }
}
