using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotePad.Classes;

namespace NotePad
{
    public partial class PersonalizarCor : Form
    {
        public PersonalizarCor()
        {
            InitializeComponent();

        }

        private void maskedTextBoxR_TextChanged(object sender, EventArgs e)
        {
            ExcecaoVazio(maskedTextBoxR);
        }

        private void PersonalizarCor_Load(object sender, EventArgs e)
        {
        }

        private int[] SalvaCores()
        {
            int[] cores = { int.Parse(maskedTextBoxR.Text), int.Parse(maskedTextBoxG.Text), int.Parse(maskedTextBoxB.Text)};
            return cores;
        }



        private void maskedTextBoxG_TextChanged(object sender, EventArgs e)
        {
            ExcecaoVazio(maskedTextBoxG);
        }

        private void maskedTextBoxB_TextChanged(object sender, EventArgs e)
        {
            ExcecaoVazio(maskedTextBoxB);
            //MessageBox.Show(Convert.ToString(Color.FromArgb(int.Parse(maskedTextBoxB.Text))));
            //panelRGB.BackColor = Color.FromArgb(int.Parse(maskedTextBoxR.Text), int.Parse(maskedTextBoxG.Text), int.Parse(maskedTextBoxB.Text));
        }

        private void ExcecaoVazio(MaskedTextBox maskedTextBox)
        {
            try
            {
                if (int.Parse(maskedTextBox.Text) > 255)
                {
                    maskedTextBox.Text = "255";
                }
            }
            catch (FormatException)
            {
                maskedTextBox.Text = "0";
            }
            panelRGB.BackColor = Color.FromArgb(int.Parse(maskedTextBoxR.Text), int.Parse(maskedTextBoxG.Text), int.Parse(maskedTextBoxB.Text));
        }

        private void caret(MaskedTextBox maskedTextBox)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                maskedTextBox.Select(0, 0);
            });
        }
        private void maskedTextBoxR_Enter(object sender, EventArgs e)
        {
            caret(maskedTextBoxR);
        }

        
        private void maskedTextBoxG_Enter(object sender, EventArgs e)
        {
            caret(maskedTextBoxG);

        }

        private void maskedTextBoxB_Enter(object sender, EventArgs e)
        {
            caret(maskedTextBoxB);

        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            panelRGB.BackColor = Color.FromArgb(int.Parse(maskedTextBoxR.Text), int.Parse(maskedTextBoxG.Text), int.Parse(maskedTextBoxB.Text));
            PersonalizaCor.Instance.GetColor[0] = int.Parse(maskedTextBoxR.Text);
            PersonalizaCor.Instance.GetColor[1] = int.Parse(maskedTextBoxG.Text);
            PersonalizaCor.Instance.GetColor[2] = int.Parse(maskedTextBoxB.Text);

            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            panelRGB.BackColor = Color.FromArgb(SalvaCores()[0], SalvaCores()[1], SalvaCores()[2]);
            this.Close();
        }
    }
}
