using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УправлениеСтилемШрифта
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Управление стилем шрифта";
            checkBox1.Text = "Полужирный";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Courier New", 12.0F, label1.Font.Style ^ FontStyle.Bold);
            //if (checkBox1.Checked)
            //{
            //    label1.Font = new Font("Courier New", 12.0F, FontStyle.Bold);

            //}
            //else
            //{
            //    label1.Font = new Font("Courier New", 12.0F, FontStyle.Regular);
            //}

        }
    }
}
