namespace FormalLanguagesApp
{
    partial class FormAddRule
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
            this.comboBoxMainNonTerminal = new System.Windows.Forms.ComboBox();
            this.comboBoxTerminal = new System.Windows.Forms.ComboBox();
            this.comboBoxNonTerminal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddRule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMainNonTerminal
            // 
            this.comboBoxMainNonTerminal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMainNonTerminal.FormattingEnabled = true;
            this.comboBoxMainNonTerminal.Location = new System.Drawing.Point(7, 14);
            this.comboBoxMainNonTerminal.MaxLength = 1;
            this.comboBoxMainNonTerminal.Name = "comboBoxMainNonTerminal";
            this.comboBoxMainNonTerminal.Size = new System.Drawing.Size(59, 30);
            this.comboBoxMainNonTerminal.TabIndex = 0;
            // 
            // comboBoxTerminal
            // 
            this.comboBoxTerminal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTerminal.FormattingEnabled = true;
            this.comboBoxTerminal.Location = new System.Drawing.Point(111, 14);
            this.comboBoxTerminal.MaxLength = 1;
            this.comboBoxTerminal.Name = "comboBoxTerminal";
            this.comboBoxTerminal.Size = new System.Drawing.Size(52, 30);
            this.comboBoxTerminal.TabIndex = 1;
            this.comboBoxTerminal.SelectedIndexChanged += new System.EventHandler(this.comboBoxTerminal_SelectedIndexChanged);
            // 
            // comboBoxNonTerminal
            // 
            this.comboBoxNonTerminal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxNonTerminal.FormattingEnabled = true;
            this.comboBoxNonTerminal.Location = new System.Drawing.Point(170, 14);
            this.comboBoxNonTerminal.MaxLength = 1;
            this.comboBoxNonTerminal.Name = "comboBoxNonTerminal";
            this.comboBoxNonTerminal.Size = new System.Drawing.Size(52, 30);
            this.comboBoxNonTerminal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(67, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "->";
            // 
            // buttonAddRule
            // 
            this.buttonAddRule.Location = new System.Drawing.Point(24, 55);
            this.buttonAddRule.Name = "buttonAddRule";
            this.buttonAddRule.Size = new System.Drawing.Size(187, 35);
            this.buttonAddRule.TabIndex = 4;
            this.buttonAddRule.Text = "Добавить правило";
            this.buttonAddRule.UseVisualStyleBackColor = true;
            this.buttonAddRule.Click += new System.EventHandler(this.buttonAddRule_Click);
            // 
            // FormAddRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 97);
            this.Controls.Add(this.buttonAddRule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNonTerminal);
            this.Controls.Add(this.comboBoxTerminal);
            this.Controls.Add(this.comboBoxMainNonTerminal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddRule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление правила";
            this.Load += new System.EventHandler(this.FormAddRule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMainNonTerminal;
        private System.Windows.Forms.ComboBox comboBoxTerminal;
        private System.Windows.Forms.ComboBox comboBoxNonTerminal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddRule;
    }
}