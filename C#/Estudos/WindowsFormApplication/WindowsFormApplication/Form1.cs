using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormApplication.Classes;
using WindowsFormApplication.MenuStripInfo;

namespace WindowsFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("Inicilizando o formulário pelo construtor");
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void abrirCadastro_Click(object sender, EventArgs e)
        {
            new Cadastro().Show();
        }

        private void abrirArquivo_Click(object sender, EventArgs e)
        {
            new Texto().Show();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add(new ToolStripMenuItem("Abrir arquivo", null, abrirArquivo_Click));
            contextMenu.Items.Add(new ToolStripMenuItem("Cadastro", null, abrirCadastro_Click));
            contextMenu.Items.Add(new ToolStripMenuItem("Fechar", null, fechar_Click));
            notifyIcon.ContextMenuStrip = contextMenu;


            //MessageBox.Show("Inicializando o formulário pelo load");
            //List<string> estados = new List<string>();


            /*cbEstados.Items.Add("São Paulo");
            cbEstados.Items.Add("Rio de Janeiro"); 
            cbEstados.Items.Add("Rio Grande do Sul");
            cbEstados.Items.Add("Minas Gerais");
            cbEstados.Items.Add("Bahia");*/
            //cbEstados.Items.Clear();
            /*foreach (Estado estado in Estado.Lista())
            {
                cbEstados.Items.Add(estado);
            }*/
            // Maneira fácil
            cbEstados.DataSource = Estado.Lista();
            cbEstados.Text = "Selecione";
            //dataGridView.DataSource = Estado.Lista();


            ////// Maneira complexa //////
            /*dataGridView.ColumnCount = 2; // Define a quantidade de colunas
            dataGridView.Columns[0].Name = "Id"; // Define que o nome da coluna 0 é ID
            dataGridView.Columns[1].Name = "Estado"; // Define que o nome da coluna 0 é Estado

            var rows = new List<string[]>();

            foreach (Estado estado in Estado.Lista())
            {
                string[] row = new string[]
                {
                    estado.Id.ToString(),
                    estado.Nome
                };
                rows.Add(row);
            }

            foreach (string[] rowArray in rows)
            {
                dataGridView.Rows.Add(rowArray);
            }*/
            ////// Maneira complexa //////

            ///// Utilizando Link - Maneira intermediária /////
            var data = from estado in Estado.Lista()
                       //where estado.Id == 2 || estado.Id == 1
                       //orderby estado.Nome
                       select new
                       {
                           Id = estado.Id,
                           Nome = estado.Nome
                       };
            dataGridView.DataSource = data.ToList();

            AtualizaHora();
        }

        private void AtualizaHora()
        {
            labelRelogio.Text = "Dia e hora: " + DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "Olá Felipe" + " - Estado: " + ((Estado)cbEstados.SelectedItem).Id;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            var form = new FrmShow();
            form.labelMensagem.Text = txtResultado.Text;
            form.Show();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Texto().Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Sobre().Show();
        }

        private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLicense().Show();
        }

        private void doaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new Donate().Show();
            Donate donate = new Donate();
            donate.MdiParent = MDISingleton.CriarInstancia();
            donate.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timerRelogio_Tick(object sender, EventArgs e)
        {
            AtualizaHora();        
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cadastro().Show();
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Clicou no ícone");
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Dois cliques");
        }

        private void buttonNotificacao_Click(object sender, EventArgs e)
        {
            notifyIcon.ShowBalloonTip(1000, "Notificação", "Notificação para o usuário", ToolTipIcon.Info);
        }

        private void buttonErro_Click(object sender, EventArgs e)
        {
            notifyIcon.ShowBalloonTip(1000, "Error", "Erro ao executar a ação", ToolTipIcon.Info);
            
        }

        private void buttonWarning_Click(object sender, EventArgs e)
        {
            notifyIcon.ShowBalloonTip(1000, "Warning", "Aviso de que algo deu errado", ToolTipIcon.Info);
        }

        private void buttonNoIcon_Click(object sender, EventArgs e)
        {
            notifyIcon.ShowBalloonTip(1000, "Sem ícone  ", "Teste sem ícone", ToolTipIcon.Info);
        }

        private void buttonMdiForm_Click(object sender, EventArgs e)
        {
            new MDIParentPrincipal().Show();
        }
    }
}
