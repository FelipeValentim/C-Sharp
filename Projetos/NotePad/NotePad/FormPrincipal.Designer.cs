
namespace NotePad
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonFileNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonFileImport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonFileSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxFonteTipo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBoxFonteTamanho = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonNegrito = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEsquerda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCentro = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDireita = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButtonCor = new System.Windows.Forms.ToolStripSplitButton();
            this.personalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonRemoveColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonResetar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabelLinhasColunas = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabelWords = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFileNew,
            this.toolStripSeparator1,
            this.toolStripButtonFileImport,
            this.toolStripSeparator2,
            this.toolStripButtonFileSave,
            this.toolStripSeparator3,
            this.toolStripComboBoxFonteTipo,
            this.toolStripComboBoxFonteTamanho,
            this.toolStripSeparator4,
            this.toolStripButtonNegrito,
            this.toolStripButtonUnderline,
            this.toolStripButtonItalic,
            this.toolStripSeparator5,
            this.toolStripButtonEsquerda,
            this.toolStripSeparator7,
            this.toolStripButtonCentro,
            this.toolStripSeparator8,
            this.toolStripButtonDireita,
            this.toolStripSeparator6,
            this.toolStripSplitButtonCor,
            this.toolStripButtonRemoveColor,
            this.toolStripSeparator9,
            this.toolStripButtonResetar,
            this.toolStripSeparator12});
            this.toolStrip.Location = new System.Drawing.Point(1, 1);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(972, 27);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonFileNew
            // 
            this.toolStripButtonFileNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFileNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFileNew.Image")));
            this.toolStripButtonFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFileNew.Name = "toolStripButtonFileNew";
            this.toolStripButtonFileNew.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonFileNew.Text = "Novo arquivo";
            this.toolStripButtonFileNew.Click += new System.EventHandler(this.toolStripButtonFileNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonFileImport
            // 
            this.toolStripButtonFileImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFileImport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFileImport.Image")));
            this.toolStripButtonFileImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFileImport.Name = "toolStripButtonFileImport";
            this.toolStripButtonFileImport.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonFileImport.Text = "Importar arquivo";
            this.toolStripButtonFileImport.Click += new System.EventHandler(this.toolStripButtonFileImport_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonFileSave
            // 
            this.toolStripButtonFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFileSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFileSave.Image")));
            this.toolStripButtonFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFileSave.Name = "toolStripButtonFileSave";
            this.toolStripButtonFileSave.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonFileSave.Text = "Salvar arquivo";
            this.toolStripButtonFileSave.Click += new System.EventHandler(this.toolStripButtonFileSave_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripComboBoxFonteTipo
            // 
            this.toolStripComboBoxFonteTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolStripComboBoxFonteTipo.Items.AddRange(new object[] {
            "Arial",
            "Verdana",
            "Bradley Hand ITC",
            "Yu Gothic Light",
            "Impact"});
            this.toolStripComboBoxFonteTipo.Name = "toolStripComboBoxFonteTipo";
            this.toolStripComboBoxFonteTipo.Size = new System.Drawing.Size(121, 27);
            this.toolStripComboBoxFonteTipo.Text = "Arial";
            this.toolStripComboBoxFonteTipo.ToolTipText = "Estilo da fonte";
            this.toolStripComboBoxFonteTipo.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFonteTipo_SelectedIndexChanged);
            // 
            // toolStripComboBoxFonteTamanho
            // 
            this.toolStripComboBoxFonteTamanho.AutoCompleteCustomSource.AddRange(new string[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.toolStripComboBoxFonteTamanho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolStripComboBoxFonteTamanho.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.toolStripComboBoxFonteTamanho.Name = "toolStripComboBoxFonteTamanho";
            this.toolStripComboBoxFonteTamanho.Size = new System.Drawing.Size(75, 27);
            this.toolStripComboBoxFonteTamanho.Text = "11";
            this.toolStripComboBoxFonteTamanho.ToolTipText = "Tamanho da fonte";
            this.toolStripComboBoxFonteTamanho.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFonteTamanho_SelectedIndexChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonNegrito
            // 
            this.toolStripButtonNegrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNegrito.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNegrito.Image")));
            this.toolStripButtonNegrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNegrito.Name = "toolStripButtonNegrito";
            this.toolStripButtonNegrito.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonNegrito.Text = "Negrito";
            this.toolStripButtonNegrito.Click += new System.EventHandler(this.toolStripButtonNegrito_Click);
            // 
            // toolStripButtonUnderline
            // 
            this.toolStripButtonUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUnderline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUnderline.Image")));
            this.toolStripButtonUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUnderline.Name = "toolStripButtonUnderline";
            this.toolStripButtonUnderline.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonUnderline.Text = "Sublinhado";
            this.toolStripButtonUnderline.Click += new System.EventHandler(this.toolStripButtonUnderline_Click);
            // 
            // toolStripButtonItalic
            // 
            this.toolStripButtonItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonItalic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonItalic.Image")));
            this.toolStripButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonItalic.Name = "toolStripButtonItalic";
            this.toolStripButtonItalic.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonItalic.Text = "Itálico";
            this.toolStripButtonItalic.Click += new System.EventHandler(this.toolStripButtonItalic_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonEsquerda
            // 
            this.toolStripButtonEsquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEsquerda.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEsquerda.Image")));
            this.toolStripButtonEsquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEsquerda.Name = "toolStripButtonEsquerda";
            this.toolStripButtonEsquerda.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonEsquerda.Text = "Alinhar para esquerda";
            this.toolStripButtonEsquerda.Click += new System.EventHandler(this.toolStripButtonEsquerda_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonCentro
            // 
            this.toolStripButtonCentro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCentro.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCentro.Image")));
            this.toolStripButtonCentro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCentro.Name = "toolStripButtonCentro";
            this.toolStripButtonCentro.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonCentro.Text = "Centralizar";
            this.toolStripButtonCentro.Click += new System.EventHandler(this.toolStripButtonCentro_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonDireita
            // 
            this.toolStripButtonDireita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDireita.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDireita.Image")));
            this.toolStripButtonDireita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDireita.Name = "toolStripButtonDireita";
            this.toolStripButtonDireita.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonDireita.Text = "Alinhar para direita";
            this.toolStripButtonDireita.Click += new System.EventHandler(this.toolStripButtonDireita_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSplitButtonCor
            // 
            this.toolStripSplitButtonCor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonCor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizarToolStripMenuItem});
            this.toolStripSplitButtonCor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonCor.Image")));
            this.toolStripSplitButtonCor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonCor.Name = "toolStripSplitButtonCor";
            this.toolStripSplitButtonCor.Size = new System.Drawing.Size(36, 24);
            this.toolStripSplitButtonCor.Text = "Mudar cor";
            this.toolStripSplitButtonCor.ButtonClick += new System.EventHandler(this.toolStripSplitButtonCor_ButtonClick);
            // 
            // personalizarToolStripMenuItem
            // 
            this.personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            this.personalizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personalizarToolStripMenuItem.Text = "Personalizar";
            this.personalizarToolStripMenuItem.Click += new System.EventHandler(this.personalizarToolStripMenuItem_Click);
            // 
            // toolStripButtonRemoveColor
            // 
            this.toolStripButtonRemoveColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveColor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemoveColor.Image")));
            this.toolStripButtonRemoveColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveColor.Name = "toolStripButtonRemoveColor";
            this.toolStripButtonRemoveColor.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonRemoveColor.Text = "Remover cor";
            this.toolStripButtonRemoveColor.Click += new System.EventHandler(this.toolStripButtonRemoveColor_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonResetar
            // 
            this.toolStripButtonResetar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonResetar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonResetar.Image")));
            this.toolStripButtonResetar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonResetar.Name = "toolStripButtonResetar";
            this.toolStripButtonResetar.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonResetar.Text = "Resetar formatação";
            this.toolStripButtonResetar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 27);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator11,
            this.toolStripStatusLabelLinhasColunas,
            this.toolStripSeparator10,
            this.toolStripStatusLabel1,
            this.toolStripSeparator13,
            this.toolStripStatusLabelWords});
            this.statusStrip1.Location = new System.Drawing.Point(1, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(972, 23);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripStatusLabelLinhasColunas
            // 
            this.toolStripStatusLabelLinhasColunas.Name = "toolStripStatusLabelLinhasColunas";
            this.toolStripStatusLabelLinhasColunas.Size = new System.Drawing.Size(118, 18);
            this.toolStripStatusLabelLinhasColunas.Text = "0 Linhas | 0 colunas   ";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 18);
            this.toolStripStatusLabel1.Text = "UTF-8   ";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripStatusLabelWords
            // 
            this.toolStripStatusLabelWords.Name = "toolStripStatusLabelWords";
            this.toolStripStatusLabelWords.Size = new System.Drawing.Size(67, 18);
            this.toolStripStatusLabelWords.Text = "Palavra(s)   ";
            // 
            // richTextBox
            // 
            this.richTextBox.AcceptsTab = true;
            this.richTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.EnableAutoDragDrop = true;
            this.richTextBox.Font = new System.Drawing.Font("Arial", 11F);
            this.richTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox.HideSelection = false;
            this.richTextBox.Location = new System.Drawing.Point(1, 28);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(972, 509);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            this.richTextBox.Click += new System.EventHandler(this.richTextBox_Click);
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(974, 561);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "NotePad - Sem título";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonFileNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonFileImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonFileSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFonteTamanho;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFonteTipo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonNegrito;
        private System.Windows.Forms.ToolStripButton toolStripButtonUnderline;
        private System.Windows.Forms.ToolStripButton toolStripButtonItalic;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonEsquerda;
        private System.Windows.Forms.ToolStripButton toolStripButtonCentro;
        private System.Windows.Forms.ToolStripButton toolStripButtonDireita;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButtonResetar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLinhasColunas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelWords;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonCor;
        private System.Windows.Forms.ToolStripMenuItem personalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveColor;
    }
}

