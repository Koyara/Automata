namespace FormalLanguagesApp
{
    partial class FormUpdateRule
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
            this.comboBoxUpdateRule = new System.Windows.Forms.ComboBox();
            this.buttonUpdateRule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNonTerminal = new System.Windows.Forms.ComboBox();
            this.comboBoxTerminal = new System.Windows.Forms.ComboBox();
            this.comboBoxMainNonTerminal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxUpdateRule
            // 
            this.comboBoxUpdateRule.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxUpdateRule.FormattingEnabled = true;
            this.comboBoxUpdateRule.Location = new System.Drawing.Point(96, 12);
            this.comboBoxUpdateRule.Name = "comboBoxUpdateRule";
            this.comboBoxUpdateRule.Size = new System.Drawing.Size(121, 30);
            this.comboBoxUpdateRule.TabIndex = 0;
            this.comboBoxUpdateRule.SelectedIndexChanged += new System.EventHandler(this.comboBoxUpdateRule_SelectedIndexChanged);
            // 
            // buttonUpdateRule
            // 
            this.buttonUpdateRule.Location = new System.Drawing.Point(25, 97);
            this.buttonUpdateRule.Name = "buttonUpdateRule";
            this.buttonUpdateRule.Size = new System.Drawing.Size(187, 35);
            this.buttonUpdateRule.TabIndex = 9;
            this.buttonUpdateRule.Text = "Изменить правило";
            this.buttonUpdateRule.UseVisualStyleBackColor = true;
            this.buttonUpdateRule.Click += new System.EventHandler(this.buttonUpdateRule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(68, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "->";
            // 
            // comboBoxNonTerminal
            // 
            this.comboBoxNonTerminal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxNonTerminal.FormattingEnabled = true;
            this.comboBoxNonTerminal.Location = new System.Drawing.Point(171, 56);
            this.comboBoxNonTerminal.MaxLength = 1;
            this.comboBoxNonTerminal.Name = "comboBoxNonTerminal";
            this.comboBoxNonTerminal.Size = new System.Drawing.Size(52, 30);
            this.comboBoxNonTerminal.TabIndex = 7;
            // 
            // comboBoxTerminal
            // 
            this.comboBoxTerminal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTerminal.FormattingEnabled = true;
            this.comboBoxTerminal.Location = new System.Drawing.Point(112, 56);
            this.comboBoxTerminal.MaxLength = 1;
            this.comboBoxTerminal.Name = "comboBoxTerminal";
            this.comboBoxTerminal.Size = new System.Drawing.Size(52, 30);
            this.comboBoxTerminal.TabIndex = 6;
            this.comboBoxTerminal.SelectedIndexChanged += new System.EventHandler(this.comboBoxTerminal_SelectedIndexChanged);
            // 
            // comboBoxMainNonTerminal
            // 
            this.comboBoxMainNonTerminal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMainNonTerminal.FormattingEnabled = true;
            this.comboBoxMainNonTerminal.Location = new System.Drawing.Point(8, 56);
            this.comboBoxMainNonTerminal.MaxLength = 1;
            this.comboBoxMainNonTerminal.Name = "comboBoxMainNonTerminal";
            this.comboBoxMainNonTerminal.Size = new System.Drawing.Size(59, 30);
            this.comboBoxMainNonTerminal.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Изменяемое\r\nправило:\r\n";
            // 
            // FormUpdateRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 139);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUpdateRule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNonTerminal);
            this.Controls.Add(this.comboBoxTerminal);
            this.Controls.Add(this.comboBoxMainNonTerminal);
            this.Controls.Add(this.comboBoxUpdateRule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUpdateRule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить правило";
            this.Load += new System.EventHandler(this.FormUpdateRule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUpdateRule;
        private System.Windows.Forms.Button buttonUpdateRule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNonTerminal;
        private System.Windows.Forms.ComboBox comboBoxTerminal;
        private System.Windows.Forms.ComboBox comboBoxMainNonTerminal;
        private System.Windows.Forms.Label label2;
    }
}