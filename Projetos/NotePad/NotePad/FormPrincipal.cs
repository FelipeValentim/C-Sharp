using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButtonFileNew_Click(object sender, EventArgs e)
        {
            MensagemSalvar();
        }

        private bool MensagemSalvar()
        {
            if (richTextBox.Text != string.Empty)
            {
                var dialogResult = MessageBox.Show("Deseja salvar o arquivo " + PegarNomeArquivo() + "?", "NotePad", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.No)
                {
                    richTextBox.Clear();
                }
                else if (dialogResult == DialogResult.Yes)
                {
                    SalvarArquivo();
                } else if (dialogResult == DialogResult.Cancel)
                {
                    return true;
                }    
            }
            return false;
        }

        private void toolStripButtonFileImport_Click(object sender, EventArgs e)
        {
            if (MensagemSalvar() == true)
            {
                return;
            }         
            var filePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Title = "Abrir arquivo de texto";
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                this.Text = "NotePad - " + openFileDialog.SafeFileName;
            }

            if (filePath != string.Empty)
            {
                richTextBox.Clear();
                richTextBox.Text = File.ReadAllText(filePath);
            }
        }

        private string PegarNomeArquivo()
        {
            string nomeForm = this.Text;
            string[] nome = nomeForm.Split(new string[] { " - " }, 2, StringSplitOptions.None);

            return nome[1];
        }

        private void toolStripComboBoxFonteTamanho_SelectedIndexChanged(object sender, EventArgs e)
        {
            float fontSize = float.Parse(toolStripComboBoxFonteTamanho.Text);
            FormataTexto(string.Empty, fontSize, false);
        }

        private void toolStripComboBoxFonteTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontStyle = toolStripComboBoxFonteTipo.Text;
            FormataTexto(fontStyle, 0, true);
        }

        private void FormataTexto(string fontName, float fontSize, bool fonte)
        {
            using (RichTextBox tmpRTB = new RichTextBox())
            {
                tmpRTB.SelectAll();
                tmpRTB.SelectedRtf = richTextBox.SelectedRtf;
                for (int i = 0; i < tmpRTB.TextLength; ++i)
                {
                    tmpRTB.Select(i, 1);
                    if (fonte)
                    {
                        tmpRTB.SelectionFont = new Font(fontName, tmpRTB.SelectionFont.Size);
                    }
                    else
                    {
                        tmpRTB.SelectionFont = new Font(tmpRTB.SelectionFont.Name, fontSize);
                    }
                    
                }
                tmpRTB.SelectAll();
                richTextBox.SelectedRtf = tmpRTB.SelectedRtf;
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            richTextBox.Font = new Font("Arial", 10);
        }

        private void toolStripButtonFileSave_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }

        private void SalvarArquivo()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivo de texto RTF(*.rtf)|*.rtf|Arquivo de texto TXT|*.txt";
            saveFileDialog.Title = "Salvar arquivo de texto";
            saveFileDialog.ShowDialog(this);

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog.FileName != "")
            {
                File.WriteAllText(saveFileDialog.FileName, richTextBox.Text);
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MensagemSalvar())
            {
                e.Cancel = true;
            }
            
        }
    }
}
