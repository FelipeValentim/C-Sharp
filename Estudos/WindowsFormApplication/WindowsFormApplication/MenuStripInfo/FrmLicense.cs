using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormApplication.MenuStripInfo
{
    public partial class FrmLicense : Form
    {
        public FrmLicense()
        {
            InitializeComponent();
        }

        private void License_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chave registrada!");
        }

        private void buttonObter_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.google.com") 
            { 
                UseShellExecute = true 
            }
            );
        }
    }
}
