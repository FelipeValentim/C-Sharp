
namespace WindowsFormApplication
{
    partial class FrmShow
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
            this.labelMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMensagem
            // 
            this.labelMensagem.AutoSize = true;
            this.labelMensagem.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMensagem.Location = new System.Drawing.Point(108, 177);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(502, 65);
            this.labelMensagem.TabIndex = 0;
            this.labelMensagem.Text = "Escrever em Runtime";
            this.labelMensagem.Click += new System.EventHandler(this.labelMensagem_Click);
            // 
            // FrmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMensagem);
            this.Name = "FrmShow";
            this.Text = "frmShow";
            this.Load += new System.EventHandler(this.frmShow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelMensagem;
    }
}