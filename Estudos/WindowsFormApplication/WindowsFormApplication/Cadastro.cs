using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormApplication
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            try
            {        
                int numero = Convert.ToInt32(textBoxNumero.Text);
                
                if (numero == 2)
                {
                    throw new ErroDeProposito("Erro de propósito");
                } else if (numero == 4)
                {
                    throw new Exception("Erro de Exception");
                }
                numero += 100;

                MessageBox.Show("Olá " + nome + ", o valor do número somado com 100 é de: " + numero);
            }
            catch (FormatException erroFormat)
            {
                MessageBox.Show("Olá, por favor digite números ao invés de letras.\n\n(" + erroFormat.Message + ")");
                textBoxNumero.Focus();
            }
            catch (ErroDeProposito erroDeProposito)
            {
                MessageBox.Show("Erro de propósito - " + erroDeProposito.StackTrace);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Olá, por favor digite números ao invés de letras.\n\n" + erro.Message);
            }
            finally
            {
                MessageBox.Show("Todas as minhas excessões tratadas");
            }

        }

        private void maskedTextBoxTelefone_Leave(object sender, EventArgs e)
        {
            if (!maskedTextBoxTelefone.MaskCompleted)
            {
                MessageBox.Show("Telefone incompleto");
            }
        }

        private void buttonTelefone_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maskedTextBoxTelefone.Text);
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void toolStripButtonBusca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buscando dados com o termo " + toolStripTextBoxBuscar);
        }
    }

    public class ErroDeProposito : Exception
    {
        public ErroDeProposito(string erro):base(erro)
        {

        }
    }
}
