using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormApplication
{
    public partial class FrmShow : Form
    {
        public FrmShow()
        {
            InitializeComponent();
        }

        private void frmShow_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Load antes do FRMShOW");
        }

        private void labelMensagem_Click(object sender, EventArgs e)
        {

        }
    }
}
