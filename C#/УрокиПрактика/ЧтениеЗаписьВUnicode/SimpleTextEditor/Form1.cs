using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Тескстовый редактор";
            openFileDialog1.FileName = "";
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == String.Empty) return;
            try
            {
                var Читатель = new System.IO.StreamReader(openFileDialog1.FileName, System.Text.Encoding.GetEncoding(1251));
                textBox1.Text = Читатель.ReadToEnd();
                Читатель.Close();
            }
            catch (Exception Исключение)
            {
                MessageBox.Show("Ошибка открытия файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
  
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) Запись(saveFileDialog1.FileName);

        }

        private void Запись(string fileName)
        {
            try
            {
                var Писатель = new System.IO.StreamWriter(fileName, false, System.Text.Encoding.GetEncoding(1251));
                Писатель.Write(textBox1.Text);
                Писатель.Close();
                textBox1.Modified = false;
            }
            catch (Exception Исключение) 
            {

                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Modified == false) return;
            var Mbox = MessageBox.Show("Файл был изменен сохранить его?", "Внимание", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

            if (Mbox == DialogResult.No) return;
            if (Mbox == DialogResult.Cancel) e.Cancel=true;
            if (Mbox == DialogResult.Yes)
            {
                try
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK) { Запись(saveFileDialog1.FileName); return; }
                    else e.Cancel = true;
                }
                catch (Exception Исключение)
                {

                    
                }
            }
        }
    }
}
