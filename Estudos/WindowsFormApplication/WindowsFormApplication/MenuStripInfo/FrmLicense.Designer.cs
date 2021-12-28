
namespace WindowsFormApplication.MenuStripInfo
{
    partial class FrmLicense
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
            this.buttonObter = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonObter
            // 
            this.buttonObter.Location = new System.Drawing.Point(12, 44);
            this.buttonObter.Name = "buttonObter";
            this.buttonObter.Size = new System.Drawing.Size(141, 41);
            this.buttonObter.TabIndex = 0;
            this.buttonObter.Text = "Obter licença";
            this.buttonObter.UseVisualStyleBackColor = true;
            this.buttonObter.Click += new System.EventHandler(this.buttonObter_Click);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(921, 148);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrar.TabIndex = 1;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(903, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Chave de acesso";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 648);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.buttonObter);
            this.Name = "FrmLicense";
            this.Text = "License";
            this.Load += new System.EventHandler(this.License_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonObter;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.TextBox textBox1;
    }
}