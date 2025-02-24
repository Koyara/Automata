namespace FormalLanguagesApp
{
    partial class FormDeleteTerminal
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
            this.comboBoxDeleteTerminal = new System.Windows.Forms.ComboBox();
            this.buttonDeleteTerminal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDeleteTerminal
            // 
            this.comboBoxDeleteTerminal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDeleteTerminal.FormattingEnabled = true;
            this.comboBoxDeleteTerminal.Location = new System.Drawing.Point(12, 12);
            this.comboBoxDeleteTerminal.MaxLength = 1;
            this.comboBoxDeleteTerminal.Name = "comboBoxDeleteTerminal";
            this.comboBoxDeleteTerminal.Size = new System.Drawing.Size(121, 30);
            this.comboBoxDeleteTerminal.TabIndex = 0;
            // 
            // buttonDeleteTerminal
            // 
            this.buttonDeleteTerminal.Location = new System.Drawing.Point(23, 50);
            this.buttonDeleteTerminal.Name = "buttonDeleteTerminal";
            this.buttonDeleteTerminal.Size = new System.Drawing.Size(99, 36);
            this.buttonDeleteTerminal.TabIndex = 1;
            this.buttonDeleteTerminal.Text = "Удалить терминал";
            this.buttonDeleteTerminal.UseVisualStyleBackColor = true;
            this.buttonDeleteTerminal.Click += new System.EventHandler(this.buttonDeleteTerminal_Click);
            // 
            // FormDeleteTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(146, 98);
            this.Controls.Add(this.buttonDeleteTerminal);
            this.Controls.Add(this.comboBoxDeleteTerminal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDeleteTerminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалить";
            this.Load += new System.EventHandler(this.FormDeleteTerminal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDeleteTerminal;
        private System.Windows.Forms.Button buttonDeleteTerminal;
    }
}