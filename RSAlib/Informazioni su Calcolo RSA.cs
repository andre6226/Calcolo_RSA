using System;
using System.Windows.Forms;

namespace RSAlib
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://raw.githubusercontent.com/andre6226/Calcolo_RSA/main/LICENSE");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
