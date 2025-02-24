namespace FormalLanguagesApp
{
    partial class FormReference
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("О программе");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Добавление терминала");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Добавление нетерминала");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Установка стартового символа");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Добавление правила");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Удаление правила");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Изменение правила");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Удаление терминала");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Удаление нетерминала");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Работа с грамматикой", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Преобразование грамматики в недетерминированный конечный автомат");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Работа с НКА", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.treeViewReference = new System.Windows.Forms.TreeView();
            this.richTextBoxReference = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // treeViewReference
            // 
            this.treeViewReference.BackColor = System.Drawing.Color.Khaki;
            this.treeViewReference.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewReference.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewReference.Location = new System.Drawing.Point(0, 0);
            this.treeViewReference.Name = "treeViewReference";
            treeNode1.Name = "nodeAboutProgram";
            treeNode1.Text = "О программе";
            treeNode2.Name = "nodeAddTerminal";
            treeNode2.Text = "Добавление терминала";
            treeNode3.Name = "nodeAddNonTerminal";
            treeNode3.Text = "Добавление нетерминала";
            treeNode4.Name = "nodeSetStartSymbol";
            treeNode4.Text = "Установка стартового символа";
            treeNode5.Name = "nodeAddRule";
            treeNode5.Text = "Добавление правила";
            treeNode6.Name = "nodeDeleteRule";
            treeNode6.Text = "Удаление правила";
            treeNode7.Name = "nodeUpdateRule";
            treeNode7.Text = "Изменение правила";
            treeNode8.Name = "nodeDeleteTerminal";
            treeNode8.Text = "Удаление терминала";
            treeNode9.Name = "nodeDeleteNonTerminal";
            treeNode9.Text = "Удаление нетерминала";
            treeNode10.Name = "nodeGrammar";
            treeNode10.Text = "Работа с грамматикой";
            treeNode11.Name = "nodeFromGrammarToNDA";
            treeNode11.Text = "Преобразование грамматики в недетерминированный конечный автомат";
            treeNode12.Name = "nodeStateMachine";
            treeNode12.Text = "Работа с НКА";
            this.treeViewReference.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode10,
            treeNode12});
            this.treeViewReference.Size = new System.Drawing.Size(249, 397);
            this.treeViewReference.TabIndex = 0;
            this.treeViewReference.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewReference_AfterSelect);
            // 
            // richTextBoxReference
            // 
            this.richTextBoxReference.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxReference.Location = new System.Drawing.Point(253, 5);
            this.richTextBoxReference.Name = "richTextBoxReference";
            this.richTextBoxReference.ReadOnly = true;
            this.richTextBoxReference.Size = new System.Drawing.Size(468, 387);
            this.richTextBoxReference.TabIndex = 1;
            this.richTextBoxReference.Text = "";
            // 
            // FormReference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(727, 397);
            this.Controls.Add(this.richTextBoxReference);
            this.Controls.Add(this.treeViewReference);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReference";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка";
            this.Load += new System.EventHandler(this.FormReference_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewReference;
        private System.Windows.Forms.RichTextBox richTextBoxReference;
    }
}