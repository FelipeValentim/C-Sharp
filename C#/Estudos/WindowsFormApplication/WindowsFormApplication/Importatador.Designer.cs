
namespace WindowsFormApplication
{
    partial class Importatador
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
            this.progressBarImportar = new System.Windows.Forms.ProgressBar();
            this.buttonImportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBarImportar
            // 
            this.progressBarImportar.Location = new System.Drawing.Point(12, 104);
            this.progressBarImportar.Name = "progressBarImportar";
            this.progressBarImportar.Size = new System.Drawing.Size(389, 110);
            this.progressBarImportar.TabIndex = 0;
            this.progressBarImportar.Click += new System.EventHandler(this.progressBarImportar_Click);
            // 
            // buttonImportar
            // 
            this.buttonImportar.Location = new System.Drawing.Point(105, 496);
            this.buttonImportar.Name = "buttonImportar";
            this.buttonImportar.Size = new System.Drawing.Size(168, 59);
            this.buttonImportar.TabIndex = 1;
            this.buttonImportar.Text = "Importar";
            this.buttonImportar.UseVisualStyleBackColor = true;
            this.buttonImportar.Click += new System.EventHandler(this.buttonImportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clique em importar para atualizar os dados.";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(12, 239);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(385, 251);
            this.textBoxLog.TabIndex = 3;
            // 
            // Importatador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 567);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonImportar);
            this.Controls.Add(this.progressBarImportar);
            this.Name = "Importatador";
            this.Text = "Importation";
            this.Load += new System.EventHandler(this.Importatador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarImportar;
        private System.Windows.Forms.Button buttonImportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLog;
    }
}