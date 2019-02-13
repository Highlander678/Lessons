using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СсылкаНаРесурсыLinkLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Click += new EventHandler(КЛИК);
            linkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(КЛИК);
            linkLabel3.Click += new EventHandler(КЛИК);
        }

        private void КЛИК (object sender, EventArgs e)
        {
            var Link = (LinkLabel)sender;
            Link.LinkColor = Color.Green;
            //Link.LinkVisited = true;

            switch (Link.Name)
            {
                case "linkLabel1":
                    System.Diagnostics.Process.Start("chrome.exe", linkLabel1.Text);
                    break;
                case "linkLabel2":
                    System.Diagnostics.Process.Start("C:\\Windows\\");
                    break;
                case "linkLabel3":
                    System.Diagnostics.Process.Start("Notepad","text.txt");
                    break;

                default:
                    break;
            }
        }
    }
}
