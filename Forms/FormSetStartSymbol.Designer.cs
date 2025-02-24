namespace FormalLanguagesApp
{
    partial class FormSetStartSymbol
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
            this.buttonStartSymbol = new System.Windows.Forms.Button();
            this.comboBoxStartSymbol = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonStartSymbol
            // 
            this.buttonStartSymbol.Location = new System.Drawing.Point(18, 48);
            this.buttonStartSymbol.Name = "buttonStartSymbol";
            this.buttonStartSymbol.Size = new System.Drawing.Size(139, 42);
            this.buttonStartSymbol.TabIndex = 0;
            this.buttonStartSymbol.Text = "Назначить стартовым символом";
            this.buttonStartSymbol.UseVisualStyleBackColor = true;
            this.buttonStartSymbol.Click += new System.EventHandler(this.buttonStartSymbol_Click);
            // 
            // comboBoxStartSymbol
            // 
            this.comboBoxStartSymbol.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStartSymbol.FormattingEnabled = true;
            this.comboBoxStartSymbol.Location = new System.Drawing.Point(12, 12);
            this.comboBoxStartSymbol.Name = "comboBoxStartSymbol";
            this.comboBoxStartSymbol.Size = new System.Drawing.Size(152, 30);
            this.comboBoxStartSymbol.TabIndex = 1;
            // 
            // FormSetStartSymbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 96);
            this.Controls.Add(this.comboBoxStartSymbol);
            this.Controls.Add(this.buttonStartSymbol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetStartSymbol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стартовый символ";
            this.Load += new System.EventHandler(this.FormSetStartSymbol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStartSymbol;
        private System.Windows.Forms.ComboBox comboBoxStartSymbol;
    }
}