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
    public partial class Importatador : Form
    {
        //private string[] linhas;
        public Importatador()
        {
            InitializeComponent();
        }

        private void progressBarImportar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonImportar_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }

            if (filePath != string.Empty)
            {
                using (var streamReader = File.OpenText(filePath))
                {
                    var linhas = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    progressBarImportar.Minimum = 0;
                    progressBarImportar.Maximum = linhas.Length; 
                    for (var i = 0; i < linhas.Length; i++)
                    {
                        progressBarImportar.Value = (i + 1);
                    }
                    textBoxLog.Text = "Todos os dados importados com sucesso!";

                }
            }
                

        }

        private void Importatador_Load(object sender, EventArgs e)
        {

        }
    }
}
