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
    public partial class Donate : Form
    {
        public Donate()
        {
            InitializeComponent();
        }

        private void Donate_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Process.Start("http://www.paypal.com.br");
            try
            {
                Process.Start("http://www.paypal.com.br");
            }
            catch (Win32Exception)
            {
                Process.Start(new ProcessStartInfo("https://www.paypal.com") 
                { 
                    UseShellExecute = true 
                }
                );
            }
        }
    }
}
