
namespace WindowsFormApplication
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTelefone = new System.Windows.Forms.Button();
            this.maskedTextBoxNomeMae = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.buttonAbrirArquivo = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBusca = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.testeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.testeToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(109, 99);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(574, 23);
            this.textBoxNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(109, 156);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(574, 23);
            this.textBoxNumero.TabIndex = 2;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCalcular.Location = new System.Drawing.Point(109, 342);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(84, 32);
            this.buttonCalcular.TabIndex = 4;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.BeepOnError = true;
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(109, 285);
            this.maskedTextBoxTelefone.Mask = "+99(99)90000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxTelefone.TabIndex = 5;
            this.maskedTextBoxTelefone.Leave += new System.EventHandler(this.maskedTextBoxTelefone_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone:";
            // 
            // buttonTelefone
            // 
            this.buttonTelefone.Location = new System.Drawing.Point(246, 284);
            this.buttonTelefone.Name = "buttonTelefone";
            this.buttonTelefone.Padding = new System.Windows.Forms.Padding(1);
            this.buttonTelefone.Size = new System.Drawing.Size(75, 23);
            this.buttonTelefone.TabIndex = 7;
            this.buttonTelefone.Text = "Telefone";
            this.buttonTelefone.UseVisualStyleBackColor = true;
            this.buttonTelefone.Click += new System.EventHandler(this.buttonTelefone_Click);
            // 
            // maskedTextBoxNomeMae
            // 
            this.maskedTextBoxNomeMae.Location = new System.Drawing.Point(109, 208);
            this.maskedTextBoxNomeMae.Mask = ">LLL??????????????????";
            this.maskedTextBoxNomeMae.Name = "maskedTextBoxNomeMae";
            this.maskedTextBoxNomeMae.Size = new System.Drawing.Size(574, 23);
            this.maskedTextBoxNomeMae.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(109, 247);
            this.maskedTextBox1.Mask = "$9.999,99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(468, 284);
            this.maskedTextBox2.Mask = "#0";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox2.TabIndex = 10;
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // buttonAbrirArquivo
            // 
            this.buttonAbrirArquivo.Location = new System.Drawing.Point(747, 155);
            this.buttonAbrirArquivo.Name = "buttonAbrirArquivo";
            this.buttonAbrirArquivo.Size = new System.Drawing.Size(75, 23);
            this.buttonAbrirArquivo.TabIndex = 11;
            this.buttonAbrirArquivo.Text = "Abrir";
            this.buttonAbrirArquivo.UseVisualStyleBackColor = true;
            this.buttonAbrirArquivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBusca,
            this.toolStripTextBoxBuscar,
            this.toolStripProgressBar1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(995, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonBusca
            // 
            this.toolStripButtonBusca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBusca.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBusca.Image")));
            this.toolStripButtonBusca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBusca.Name = "toolStripButtonBusca";
            this.toolStripButtonBusca.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBusca.Text = "toolStripButton1";
            // 
            // toolStripTextBoxBuscar
            // 
            this.toolStripTextBoxBuscar.Name = "toolStripTextBoxBuscar";
            this.toolStripTextBoxBuscar.Size = new System.Drawing.Size(200, 25);
            this.toolStripTextBoxBuscar.Text = "Buscar";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripSplitButton1,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 506);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(995, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(144, 17);
            this.toolStripStatusLabel1.Text = "@ Felipe Valentim da Silva";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem1,
            this.testeToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // testeToolStripMenuItem1
            // 
            this.testeToolStripMenuItem1.Name = "testeToolStripMenuItem1";
            this.testeToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.testeToolStripMenuItem1.Text = "teste";
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.testeToolStripMenuItem.Text = "teste";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem3,
            this.testeToolStripMenuItem2});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // testeToolStripMenuItem3
            // 
            this.testeToolStripMenuItem3.Name = "testeToolStripMenuItem3";
            this.testeToolStripMenuItem3.Size = new System.Drawing.Size(99, 22);
            this.testeToolStripMenuItem3.Text = "teste";
            // 
            // testeToolStripMenuItem2
            // 
            this.testeToolStripMenuItem2.Name = "testeToolStripMenuItem2";
            this.testeToolStripMenuItem2.Size = new System.Drawing.Size(99, 22);
            this.testeToolStripMenuItem2.Text = "teste";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 528);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonAbrirArquivo);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.maskedTextBoxNomeMae);
            this.Controls.Add(this.buttonTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNome);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNomeMae;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button buttonAbrirArquivo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBusca;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxBuscar;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem2;
    }
}