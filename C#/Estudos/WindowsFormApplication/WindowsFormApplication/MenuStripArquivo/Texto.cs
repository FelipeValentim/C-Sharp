using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormApplication
{
    public partial class Texto : Form
    {
        public Texto()
        {
            InitializeComponent();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Texto_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }

        private void SalvarArquivo()
        {
            File.WriteAllText(@"C:\Arquivos\texto_" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".txt", textBox1.Text);
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
