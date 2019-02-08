using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ФорматСтрокиКонсоль
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int A = 1;
            double B = 2.12345678;

            label1.Text = string.Format("{0,55}{1,28:F3}", A, B);

        }
    }
}
