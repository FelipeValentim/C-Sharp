
namespace WindowsFormApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.cbEstados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelNomeGrid = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licençaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelRelogio = new System.Windows.Forms.Label();
            this.timerRelogio = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonNotificacao = new System.Windows.Forms.Button();
            this.buttonErro = new System.Windows.Forms.Button();
            this.buttonWarning = new System.Windows.Forms.Button();
            this.buttonNoIcon = new System.Windows.Forms.Button();
            this.buttonMdiForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pressione OK para preencher a caixa de texto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 181);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(393, 23);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 225);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 41);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(12, 598);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(86, 40);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "Abrir janela";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // cbEstados
            // 
            this.cbEstados.FormattingEnabled = true;
            this.cbEstados.Location = new System.Drawing.Point(284, 243);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Size = new System.Drawing.Size(121, 23);
            this.cbEstados.TabIndex = 4;
            this.cbEstados.Text = "Selecione";
            this.cbEstados.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(284, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estados";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(542, 386);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(294, 150);
            this.dataGridView.TabIndex = 6;
            // 
            // labelNomeGrid
            // 
            this.labelNomeGrid.AutoSize = true;
            this.labelNomeGrid.Location = new System.Drawing.Point(611, 368);
            this.labelNomeGrid.Name = "labelNomeGrid";
            this.labelNomeGrid.Size = new System.Drawing.Size(161, 15);
            this.labelNomeGrid.TabIndex = 7;
            this.labelNomeGrid.Text = "Dados da Coleção de Estados";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.licençaToolStripMenuItem,
            this.doaçãoToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // licençaToolStripMenuItem
            // 
            this.licençaToolStripMenuItem.Name = "licençaToolStripMenuItem";
            this.licençaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.licençaToolStripMenuItem.Text = "Licença";
            this.licençaToolStripMenuItem.Click += new System.EventHandler(this.licençaToolStripMenuItem_Click);
            // 
            // doaçãoToolStripMenuItem
            // 
            this.doaçãoToolStripMenuItem.Name = "doaçãoToolStripMenuItem";
            this.doaçãoToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.doaçãoToolStripMenuItem.Text = "Doação";
            this.doaçãoToolStripMenuItem.Click += new System.EventHandler(this.doaçãoToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // labelRelogio
            // 
            this.labelRelogio.AutoSize = true;
            this.labelRelogio.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRelogio.Location = new System.Drawing.Point(750, 33);
            this.labelRelogio.Name = "labelRelogio";
            this.labelRelogio.Size = new System.Drawing.Size(229, 20);
            this.labelRelogio.TabIndex = 9;
            this.labelRelogio.Text = "Dia e hora: 01/01/0000 - 00:00:00";
            this.labelRelogio.Click += new System.EventHandler(this.label3_Click);
            // 
            // timerRelogio
            // 
            this.timerRelogio.Enabled = true;
            this.timerRelogio.Interval = 1000;
            this.timerRelogio.Tick += new System.EventHandler(this.timerRelogio_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Programa de teste\r\nWindows Application\r\n";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // buttonNotificacao
            // 
            this.buttonNotificacao.Location = new System.Drawing.Point(725, 109);
            this.buttonNotificacao.Name = "buttonNotificacao";
            this.buttonNotificacao.Size = new System.Drawing.Size(123, 35);
            this.buttonNotificacao.TabIndex = 10;
            this.buttonNotificacao.Text = "Notificação";
            this.buttonNotificacao.UseVisualStyleBackColor = true;
            this.buttonNotificacao.Click += new System.EventHandler(this.buttonNotificacao_Click);
            // 
            // buttonErro
            // 
            this.buttonErro.Location = new System.Drawing.Point(725, 150);
            this.buttonErro.Name = "buttonErro";
            this.buttonErro.Size = new System.Drawing.Size(123, 35);
            this.buttonErro.TabIndex = 11;
            this.buttonErro.Text = "Erro";
            this.buttonErro.UseVisualStyleBackColor = true;
            this.buttonErro.Click += new System.EventHandler(this.buttonErro_Click);
            // 
            // buttonWarning
            // 
            this.buttonWarning.Location = new System.Drawing.Point(725, 191);
            this.buttonWarning.Name = "buttonWarning";
            this.buttonWarning.Size = new System.Drawing.Size(123, 35);
            this.buttonWarning.TabIndex = 12;
            this.buttonWarning.Text = "Warning";
            this.buttonWarning.UseVisualStyleBackColor = true;
            this.buttonWarning.Click += new System.EventHandler(this.buttonWarning_Click);
            // 
            // buttonNoIcon
            // 
            this.buttonNoIcon.Location = new System.Drawing.Point(725, 232);
            this.buttonNoIcon.Name = "buttonNoIcon";
            this.buttonNoIcon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonNoIcon.Size = new System.Drawing.Size(123, 35);
            this.buttonNoIcon.TabIndex = 13;
            this.buttonNoIcon.Text = "NoIcon";
            this.buttonNoIcon.UseVisualStyleBackColor = true;
            this.buttonNoIcon.Click += new System.EventHandler(this.buttonNoIcon_Click);
            // 
            // buttonMdiForm
            // 
            this.buttonMdiForm.Location = new System.Drawing.Point(561, 109);
            this.buttonMdiForm.Name = "buttonMdiForm";
            this.buttonMdiForm.Size = new System.Drawing.Size(75, 23);
            this.buttonMdiForm.TabIndex = 14;
            this.buttonMdiForm.Text = "button1";
            this.buttonMdiForm.UseVisualStyleBackColor = true;
            this.buttonMdiForm.Click += new System.EventHandler(this.buttonMdiForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.buttonMdiForm);
            this.Controls.Add(this.buttonNoIcon);
            this.Controls.Add(this.buttonWarning);
            this.Controls.Add(this.buttonErro);
            this.Controls.Add(this.buttonNotificacao);
            this.Controls.Add(this.labelRelogio);
            this.Controls.Add(this.labelNomeGrid);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEstados);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.ComboBox cbEstados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelNomeGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licençaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doaçãoToolStripMenuItem;
        private System.Windows.Forms.Label labelRelogio;
        private System.Windows.Forms.Timer timerRelogio;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button buttonNotificacao;
        private System.Windows.Forms.Button buttonErro;
        private System.Windows.Forms.Button buttonWarning;
        private System.Windows.Forms.Button buttonNoIcon;
        private System.Windows.Forms.Button buttonMdiForm;
    }
}

