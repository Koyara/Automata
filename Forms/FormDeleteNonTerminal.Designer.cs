namespace FormalLanguagesApp
{
    partial class FormDeleteNonTerminal
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
            this.buttonDeleteNonTerminal = new System.Windows.Forms.Button();
            this.comboBoxDeleteNonTerminal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonDeleteNonTerminal
            // 
            this.buttonDeleteNonTerminal.Location = new System.Drawing.Point(23, 50);
            this.buttonDeleteNonTerminal.Name = "buttonDeleteNonTerminal";
            this.buttonDeleteNonTerminal.Size = new System.Drawing.Size(99, 36);
            this.buttonDeleteNonTerminal.TabIndex = 3;
            this.buttonDeleteNonTerminal.Text = "Удалить нетерминал";
            this.buttonDeleteNonTerminal.UseVisualStyleBackColor = true;
            this.buttonDeleteNonTerminal.Click += new System.EventHandler(this.buttonDeleteNonTerminal_Click);
            // 
            // comboBoxDeleteNonTerminal
            // 
            this.comboBoxDeleteNonTerminal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDeleteNonTerminal.FormattingEnabled = true;
            this.comboBoxDeleteNonTerminal.Location = new System.Drawing.Point(12, 12);
            this.comboBoxDeleteNonTerminal.MaxLength = 1;
            this.comboBoxDeleteNonTerminal.Name = "comboBoxDeleteNonTerminal";
            this.comboBoxDeleteNonTerminal.Size = new System.Drawing.Size(121, 30);
            this.comboBoxDeleteNonTerminal.TabIndex = 2;
            // 
            // FormDeleteNonTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 94);
            this.Controls.Add(this.buttonDeleteNonTerminal);
            this.Controls.Add(this.comboBoxDeleteNonTerminal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDeleteNonTerminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление";
            this.Load += new System.EventHandler(this.FormDeleteNonTerminal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteNonTerminal;
        private System.Windows.Forms.ComboBox comboBoxDeleteNonTerminal;
    }
}