using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПривязкаСобытияНаКнопку
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Кнопка = new Button();
            Кнопка.Text = "Программная кнопка";
            Кнопка.Visible = true;
            Кнопка.Size = new Size(150, 30);
            Кнопка.Location = new Point(70, 80);
            this.Controls.Add(Кнопка);

            Кнопка.Click += new EventHandler(Клик);
            Кнопка.Click += new EventHandler(Клик2);


        }

        private void Клик(object sender, EventArgs e)
        {
            MessageBox.Show("Нажата \"Программная\" кнопка","Нажата кнопка", MessageBoxButtons.OK,MessageBoxIcon.Information);
                
        }

        private void Клик2(object sender, EventArgs e)
        {
            MessageBox.Show("Это вторая функция которая приязана на событие Кнопка.Click", "Вторая функция к событию Кнопка.Click", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }
}
