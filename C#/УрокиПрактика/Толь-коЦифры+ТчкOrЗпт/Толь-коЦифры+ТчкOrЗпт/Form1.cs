using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Толь_коЦифры_ТчкOrЗпт
{
    public partial class Form1 : Form
    {
        string ТчкИлиЗпт;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ТчкИлиЗпт = System.Globalization.
                 NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
            //textBox1.Text = Convert.ToString(ТчкИлиЗпт);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool ТчкИлиЗптНАЙДЕНА = false;
            if (char.IsDigit(e.KeyChar)==true) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return; //Нажата клавиша Back Space - разрешить 
            if (textBox1.Text.IndexOf(ТчкИлиЗпт) != -1) ТчкИлиЗптНАЙДЕНА = true; //Ищем в тексте разделитель вещественного числа согласно региону
            if (ТчкИлиЗптНАЙДЕНА == true) { e.Handled = true; return; } // Если разделитель найден то запрещаем ввод еще одного
            if (e.KeyChar.ToString() == ТчкИлиЗпт) return; // проверяем что введен разделитель вещественного числа

            e.Handled = true; // Делаем запрет на введние других символов
        }

       
    }
}
