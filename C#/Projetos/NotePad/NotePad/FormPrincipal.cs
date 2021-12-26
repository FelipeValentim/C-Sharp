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
            //new FormPrincipal().Show();
            richTextBox.Clear();

            //this.Close();
        }

        private void toolStripButtonFileImport_Click(object sender, EventArgs e)
        {
            string[] linhas = { };
            var filePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Title = "Abrir arquivo de texto";
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }

            if (filePath != string.Empty)
            {
                richTextBox.Clear();
                richTextBox.Text = File.ReadAllText(filePath);
                /*using (var streamReader = File.OpenText(filePath))
                {
                    linhas = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    //textBox.Text += linhas;
                }*/
            }

            /*foreach (string s in linhas)
            {
                textBox.Text += s + "\n";
                
            }*/
        }

        private void toolStripComboBoxFonteTamanho_SelectedIndexChanged(object sender, EventArgs e)
        {
            float fontSize = float.Parse(toolStripComboBoxFonteTamanho.Text);
            //string fontSize = (toolStripComboBoxFonteTamanho.Text);
            //textBox.Select
            //textBox.Font = new Font(textBox.Font.FontFamily, fontSize);
            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, fontSize);
        }

        private void toolStripComboBoxFonteTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            float fontSize = richTextBox.SelectionFont.Size;
            string fontStyle = toolStripComboBoxFonteTipo.Text;
            richTextBox.SelectionFont = new Font(fontStyle, fontSize);
        }

        private void richTextBox_SelectionChanged(object sender, EventArgs e)
        {
            /*toolStripComboBoxFonteTamanho.Text = Convert.ToString(richTextBox.SelectionFont.Size);
            toolStripComboBoxFonteTipo.Text = richTextBox.SelectionFont.Name;*/

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            richTextBox.Font = new Font("Arial", 10);
        }

        private void toolStripButtonFileSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivo de texto (*.txt)|*.txt";
            saveFileDialog.Title = "Salvar arquivo de texto";
            saveFileDialog.ShowDialog(this);

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog.FileName != "")
            {
                File.WriteAllText(saveFileDialog.FileName, richTextBox.Text);
            }
        }
    }
}
