using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Blue;
            this.Opacity = 90;
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.Size = new Size(300, 600);
            Button button2 = new System.Windows.Forms.Button();
            button2.Text = "Новая кнопка";
            button2.UseVisualStyleBackColor = true;
            button2.Size = new System.Drawing.Size(75, 23);
            button2.Size = new Size(90, 30);
            this.Controls.Add(button2);
            //button2.Show();

             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }
    }
}
