using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormApplication
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void buttonAlerta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O dado digitado é: " + textBoxNome.Text);
            panelCadastro.Visible = false;
            panelTelefone.Visible = true;
        }

        private void buttonMostrarCadastro_Click(object sender, EventArgs e)
        {
            panelCadastro.Visible = true;
            panelTelefone.Visible = false;
        }

        private void panelTelefone_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMostrarTelefone_Click(object sender, EventArgs e)
        {
            panelCadastro.Visible = false;
            panelTelefone.Visible = true;
        }
    }
}
