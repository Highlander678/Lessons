using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = null;

            var Месяцы = new Dictionary<String, int>();
            Месяцы["Январь"] = 1;
            Месяцы.Add("Февраль", 2);
            Месяцы["Март"] = 3;
            Месяцы.Add("Апрель", 4);
            Месяцы["Май"] = 5;
            Месяцы.Add("Июнь", 6);

            foreach (var Месяц in Месяцы)
            {
                label1.Text += Месяц.Key + " - " + Месяц.Value + "\n";
            }


        }
    }
}
