using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL
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
            var Каталог = new ADOX.Catalog();
            try
            {
                Каталог.Create("Provider=Microsoft.Jet." +
                         "OLEDB.4.0;Data Source=new_BD.mdb");
                MessageBox.Show("База успешно создана");
            }
            catch (System.Runtime.InteropServices.COMException Ситуация)
            {

                MessageBox.Show(Ситуация.Message);
            }
        }
    }
}
