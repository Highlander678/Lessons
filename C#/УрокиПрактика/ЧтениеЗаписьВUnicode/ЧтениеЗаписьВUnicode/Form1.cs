using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЧтениеЗаписьВUnicode
{
    public partial class Form1 : Form
    {
        string ИмяФайла = "test.txt";
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var Читатель = new System.IO.StreamReader(ИмяФайла);
                textBox1.Text = Читатель.ReadToEnd();
                Читатель.Close();
                button2.Enabled = true;
            }
            catch (System.IO.FileNotFoundException Ситуация)
            {
                MessageBox.Show("Файл не найден", "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ситуация)
            {
                //
                MessageBox.Show("Возникла ошибка при открытии файла", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var Писатель = new System.IO.StreamWriter(ИмяФайла, false); // команда false перезаписывает файл
                Писатель.Write(textBox1.Text);
                Писатель.Close();
                button2.Enabled = false;
            }
            catch (Exception Ситуация)
            {
                MessageBox.Show("Какая-то ошибка с файлом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
