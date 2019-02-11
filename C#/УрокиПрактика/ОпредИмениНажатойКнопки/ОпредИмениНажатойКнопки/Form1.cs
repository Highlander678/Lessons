using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОпредИмениНажатойКнопки
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(КЛИК);
            button2.Click += new EventHandler(КЛИК);
        }

        private void КЛИК(object sender, EventArgs e)
        {
            var Кнопка = (Button)sender;
            //label1.Text = string.Format("Нажата кнопка {0}", ((Button)sender).Text);
            label1.Text = string.Format("Нажата кнопка {0}", Кнопка.Text);
        }

    }
}
