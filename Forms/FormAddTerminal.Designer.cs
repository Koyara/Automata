namespace FormalLanguagesApp
{
    partial class FormAddTerminal
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
            this.textBoxAddTerminal = new System.Windows.Forms.TextBox();
            this.buttonAddTerminal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAddTerminal
            // 
            this.textBoxAddTerminal.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddTerminal.Location = new System.Drawing.Point(16, 15);
            this.textBoxAddTerminal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAddTerminal.MaxLength = 1;
            this.textBoxAddTerminal.Name = "textBoxAddTerminal";
            this.textBoxAddTerminal.Size = new System.Drawing.Size(243, 43);
            this.textBoxAddTerminal.TabIndex = 0;
            this.textBoxAddTerminal.TextChanged += new System.EventHandler(this.textBoxAddTerminal_TextChanged);
            // 
            // buttonAddTerminal
            // 
            this.buttonAddTerminal.Location = new System.Drawing.Point(16, 66);
            this.buttonAddTerminal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddTerminal.Name = "buttonAddTerminal";
            this.buttonAddTerminal.Size = new System.Drawing.Size(244, 41);
            this.buttonAddTerminal.TabIndex = 1;
            this.buttonAddTerminal.Text = "Добавить терминал";
            this.buttonAddTerminal.UseVisualStyleBackColor = true;
            this.buttonAddTerminal.Click += new System.EventHandler(this.buttonAddTerminal_Click);
            // 
            // FormAddTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 113);
            this.Controls.Add(this.buttonAddTerminal);
            this.Controls.Add(this.textBoxAddTerminal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddTerminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddTerminal;
        private System.Windows.Forms.Button buttonAddTerminal;
    }
}