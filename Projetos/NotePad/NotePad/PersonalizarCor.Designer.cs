
namespace NotePad
{
    partial class PersonalizarCor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalizarCor));
            this.panelRGB = new System.Windows.Forms.Panel();
            this.labelR = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.maskedTextBoxR = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxG = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxB = new System.Windows.Forms.MaskedTextBox();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelRGB
            // 
            this.panelRGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelRGB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelRGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRGB.Location = new System.Drawing.Point(60, 69);
            this.panelRGB.Name = "panelRGB";
            this.panelRGB.Size = new System.Drawing.Size(350, 295);
            this.panelRGB.TabIndex = 0;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR.Location = new System.Drawing.Point(497, 129);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(22, 20);
            this.labelR.TabIndex = 4;
            this.labelR.Text = "R:";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.labelG.Location = new System.Drawing.Point(496, 204);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(23, 20);
            this.labelG.TabIndex = 5;
            this.labelG.Text = "G:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.labelB.Location = new System.Drawing.Point(497, 282);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(22, 20);
            this.labelB.TabIndex = 6;
            this.labelB.Text = "B:";
            // 
            // maskedTextBoxR
            // 
            this.maskedTextBoxR.Location = new System.Drawing.Point(526, 128);
            this.maskedTextBoxR.Mask = "099";
            this.maskedTextBoxR.Name = "maskedTextBoxR";
            this.maskedTextBoxR.PromptChar = ' ';
            this.maskedTextBoxR.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxR.TabIndex = 7;
            this.maskedTextBoxR.Text = "0";
            this.maskedTextBoxR.TextChanged += new System.EventHandler(this.maskedTextBoxR_TextChanged);
            this.maskedTextBoxR.Enter += new System.EventHandler(this.maskedTextBoxR_Enter);
            // 
            // maskedTextBoxG
            // 
            this.maskedTextBoxG.Location = new System.Drawing.Point(525, 206);
            this.maskedTextBoxG.Mask = "099";
            this.maskedTextBoxG.Name = "maskedTextBoxG";
            this.maskedTextBoxG.PromptChar = ' ';
            this.maskedTextBoxG.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxG.TabIndex = 8;
            this.maskedTextBoxG.Text = "0";
            this.maskedTextBoxG.TextChanged += new System.EventHandler(this.maskedTextBoxG_TextChanged);
            this.maskedTextBoxG.Enter += new System.EventHandler(this.maskedTextBoxG_Enter);
            // 
            // maskedTextBoxB
            // 
            this.maskedTextBoxB.Location = new System.Drawing.Point(525, 284);
            this.maskedTextBoxB.Mask = "099";
            this.maskedTextBoxB.Name = "maskedTextBoxB";
            this.maskedTextBoxB.PromptChar = ' ';
            this.maskedTextBoxB.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxB.TabIndex = 9;
            this.maskedTextBoxB.Text = "0";
            this.maskedTextBoxB.TextChanged += new System.EventHandler(this.maskedTextBoxB_TextChanged);
            this.maskedTextBoxB.Enter += new System.EventHandler(this.maskedTextBoxB_Enter);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionar.Location = new System.Drawing.Point(500, 356);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(75, 23);
            this.buttonSelecionar.TabIndex = 10;
            this.buttonSelecionar.Text = "Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(582, 355);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // PersonalizarCor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.maskedTextBoxB);
            this.Controls.Add(this.maskedTextBoxG);
            this.Controls.Add(this.maskedTextBoxR);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.panelRGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonalizarCor";
            this.Text = "Personalizar cor";
            this.Load += new System.EventHandler(this.PersonalizarCor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRGB;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxR;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxG;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxB;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}