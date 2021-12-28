
namespace WindowsFormApplication
{
    partial class Panel
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
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.buttonAlerta = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMostrarCadastro = new System.Windows.Forms.Button();
            this.panelTelefone = new System.Windows.Forms.Panel();
            this.buttonTelefone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.buttonMostrarTelefone = new System.Windows.Forms.Button();
            this.panelCadastro.SuspendLayout();
            this.panelTelefone.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCadastro
            // 
            this.panelCadastro.Controls.Add(this.buttonAlerta);
            this.panelCadastro.Controls.Add(this.textBoxNome);
            this.panelCadastro.Controls.Add(this.label1);
            this.panelCadastro.Location = new System.Drawing.Point(12, 90);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(308, 289);
            this.panelCadastro.TabIndex = 0;
            this.panelCadastro.Visible = false;
            // 
            // buttonAlerta
            // 
            this.buttonAlerta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAlerta.Location = new System.Drawing.Point(189, 20);
            this.buttonAlerta.Name = "buttonAlerta";
            this.buttonAlerta.Size = new System.Drawing.Size(75, 23);
            this.buttonAlerta.TabIndex = 2;
            this.buttonAlerta.Text = "Ok";
            this.buttonAlerta.UseVisualStyleBackColor = true;
            this.buttonAlerta.Click += new System.EventHandler(this.buttonAlerta_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(71, 20);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 23);
            this.textBoxNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // buttonMostrarCadastro
            // 
            this.buttonMostrarCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMostrarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrarCadastro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMostrarCadastro.Location = new System.Drawing.Point(12, 24);
            this.buttonMostrarCadastro.Name = "buttonMostrarCadastro";
            this.buttonMostrarCadastro.Size = new System.Drawing.Size(147, 50);
            this.buttonMostrarCadastro.TabIndex = 1;
            this.buttonMostrarCadastro.Text = "Mostrar cadastro";
            this.buttonMostrarCadastro.UseVisualStyleBackColor = true;
            this.buttonMostrarCadastro.Click += new System.EventHandler(this.buttonMostrarCadastro_Click);
            // 
            // panelTelefone
            // 
            this.panelTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTelefone.Controls.Add(this.buttonTelefone);
            this.panelTelefone.Controls.Add(this.label2);
            this.panelTelefone.Controls.Add(this.textBoxTelefone);
            this.panelTelefone.Location = new System.Drawing.Point(371, 90);
            this.panelTelefone.Name = "panelTelefone";
            this.panelTelefone.Size = new System.Drawing.Size(318, 289);
            this.panelTelefone.TabIndex = 2;
            this.panelTelefone.Visible = false;
            this.panelTelefone.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTelefone_Paint);
            // 
            // buttonTelefone
            // 
            this.buttonTelefone.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.buttonTelefone.FlatAppearance.BorderSize = 3;
            this.buttonTelefone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonTelefone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonTelefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTelefone.Location = new System.Drawing.Point(214, 41);
            this.buttonTelefone.Name = "buttonTelefone";
            this.buttonTelefone.Size = new System.Drawing.Size(75, 35);
            this.buttonTelefone.TabIndex = 2;
            this.buttonTelefone.Text = "Ok";
            this.buttonTelefone.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone:";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(78, 42);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(100, 23);
            this.textBoxTelefone.TabIndex = 0;
            // 
            // buttonMostrarTelefone
            // 
            this.buttonMostrarTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMostrarTelefone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMostrarTelefone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMostrarTelefone.Location = new System.Drawing.Point(371, 24);
            this.buttonMostrarTelefone.Name = "buttonMostrarTelefone";
            this.buttonMostrarTelefone.Size = new System.Drawing.Size(147, 50);
            this.buttonMostrarTelefone.TabIndex = 3;
            this.buttonMostrarTelefone.Text = "Mostrar telefone";
            this.buttonMostrarTelefone.UseVisualStyleBackColor = true;
            this.buttonMostrarTelefone.Click += new System.EventHandler(this.buttonMostrarTelefone_Click);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMostrarTelefone);
            this.Controls.Add(this.panelTelefone);
            this.Controls.Add(this.buttonMostrarCadastro);
            this.Controls.Add(this.panelCadastro);
            this.Name = "Panel";
            this.Text = "PanelTabControl";
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            this.panelTelefone.ResumeLayout(false);
            this.panelTelefone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCadastro;
        private System.Windows.Forms.Button buttonAlerta;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMostrarCadastro;
        private System.Windows.Forms.Panel panelTelefone;
        private System.Windows.Forms.Button buttonTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Button buttonMostrarTelefone;
    }
}