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
using NotePad.Classes;

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
                var dialogResult = MessageBox.Show("Deseja salvar o arquivo " + PegarNomeArquivo() + "?", "NotePad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
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
            //openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Arquivo RTF (*.rtf*)|*.rtf*";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                this.Text = "NotePad - " + openFileDialog.SafeFileName;
            }

            if (filePath != string.Empty)
            {
                richTextBox.Clear();
                if (string.Equals(Path.GetExtension(filePath), ".txt"))
                {
                    richTextBox.Text = File.ReadAllText(filePath);
                }
                else
                {
                    richTextBox.LoadFile(filePath);
                }
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
            FormataTexto(string.Empty, fontSize, FontStyle.Regular, "fontSize");
        }

        private void toolStripComboBoxFonteTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontStyle = toolStripComboBoxFonteTipo.Text;
            FormataTexto(fontStyle, 0, FontStyle.Regular, "fontName");
        }

        private void FormataTexto(string fontName, float fontSize, FontStyle style, string choice)
        {
            richTextBox = FormatText.FormataTexto(fontName, fontSize, style, choice, richTextBox);
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

            // Se o arquivo não seja vazio
            if (saveFileDialog.FileName != string.Empty)
            {
                if (string.Equals(Path.GetExtension(saveFileDialog.FileName), ".rtf"))
                {
                    richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
                    //File.WriteAllText(saveFileDialog.FileName, richTextBox.Text);
                //richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MensagemSalvar())
            {
                e.Cancel = true;
            }
            
        }

        private void toolStripButtonNegrito_Click(object sender, EventArgs e)
        {
            FormataTexto(" ", 0, FontStyle.Bold, "fontStyle");    
        }

        private void toolStripButtonUnderline_Click(object sender, EventArgs e)
        {
            FormataTexto(" ", 0, FontStyle.Underline, "fontStyle");
        }

        private void toolStripButtonItalic_Click(object sender, EventArgs e)
        {
            FormataTexto(" ", 0, FontStyle.Italic, "fontStyle");
        }

        private void toolStripButtonEsquerda_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButtonCentro_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButtonDireita_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormataTexto("Arial", 11, FontStyle.Regular, "reset");
            GetValuesText();
        }

        private void toolStripComboBoxFonteTamanho_TextUpdate(object sender, EventArgs e)
        {
            float fontSize = float.Parse(toolStripComboBoxFonteTipo.Text);
            FormataTexto(string.Empty, fontSize, FontStyle.Regular, "fontSize");
        }

        private void richTextBox_Click(object sender, EventArgs e)
        {
            //GetValuesText();
            GetRowsColumns();
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            richTextBox.Font = new Font("Arial", 11);
            GetRowsColumns();
            GetWords();
        }

        private void GetValuesText()
        {
            toolStripComboBoxFonteTamanho.Text = Convert.ToString(richTextBox.SelectionFont.Size);
            toolStripComboBoxFonteTipo.Text = richTextBox.SelectionFont.Name;
        }

        private void GetRowsColumns()
        {
            // Contar colunas e linhas
            int index = richTextBox.SelectionStart;
            int li = richTextBox.GetLineFromCharIndex(index);
            int firstChar = richTextBox.GetFirstCharIndexFromLine(li);
            int col;
            col = index - firstChar;

            toolStripStatusLabelLinhasColunas.Text = li + " linhas | " + col + " colunas   ";
        }

        private void GetWords()
        {
            int wordCount = 0, index = 0;
            while (index < richTextBox.Text.Length && char.IsWhiteSpace(richTextBox.Text[index]))
            {
                index++;
            }

            while (index < richTextBox.Text.Length)
            {
                // Checa se o char não é um espaço em branco
                while (index < richTextBox.Text.Length && !char.IsWhiteSpace(richTextBox.Text[index]))
                {
                    index++;
                }

                wordCount++;

                // Pula espaços em branco
                while (index < richTextBox.Text.Length && char.IsWhiteSpace(richTextBox.Text[index]))
                {
                    index++;
                }
            }
            toolStripStatusLabelWords.Text = ((wordCount == 0) ? "Palavra(s)" : wordCount + " palavra(s)  ");
        }
    }
}
