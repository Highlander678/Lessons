using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Datebase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (UserContext userContext = new UserContext())
            {
                User user1 = new User() { Name = "Alex", Age = 23 };
                User user2 = new User() { Name = "Petr", Age = 30 };
                userContext.Users.Add(user1);
                userContext.Users.Add(user2);
                userContext.SaveChanges();
                this.textBox1.Text = "База обновлена";
            }
        }
    }
}
