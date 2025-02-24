namespace FormalLanguagesApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextBoxGrammar = new System.Windows.Forms.RichTextBox();
            this.TextBoxStateMachine = new System.Windows.Forms.RichTextBox();
            this.contextMenuForUpdateGrammar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemAddNonTerminal = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAddTerminal = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSetStartSymbol = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAddRule = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDeleteRule = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUpdateRule = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDeleteTerminal = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDeleteNonTerminal = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.грамматикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНетерминалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТерминалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.установитьСтартовыйНетерминалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПравилоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПравилоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьПравилоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТерминалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьНетерминалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonGrammarToStateMachine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКонечноеСостояниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuForUpdateGrammar.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxGrammar
            // 
            this.TextBoxGrammar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TextBoxGrammar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxGrammar.Location = new System.Drawing.Point(16, 75);
            this.TextBoxGrammar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxGrammar.Name = "TextBoxGrammar";
            this.TextBoxGrammar.ReadOnly = true;
            this.TextBoxGrammar.Size = new System.Drawing.Size(484, 311);
            this.TextBoxGrammar.TabIndex = 0;
            this.TextBoxGrammar.Text = "";
            this.TextBoxGrammar.WordWrap = false;
            this.TextBoxGrammar.TextChanged += new System.EventHandler(this.TextBoxGrammar_TextChanged);
            // 
            // TextBoxStateMachine
            // 
            this.TextBoxStateMachine.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TextBoxStateMachine.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxStateMachine.Location = new System.Drawing.Point(571, 75);
            this.TextBoxStateMachine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxStateMachine.Name = "TextBoxStateMachine";
            this.TextBoxStateMachine.ReadOnly = true;
            this.TextBoxStateMachine.Size = new System.Drawing.Size(479, 672);
            this.TextBoxStateMachine.TabIndex = 1;
            this.TextBoxStateMachine.Text = "";
            this.TextBoxStateMachine.WordWrap = false;
            // 
            // contextMenuForUpdateGrammar
            // 
            this.contextMenuForUpdateGrammar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuForUpdateGrammar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAddNonTerminal,
            this.MenuItemAddTerminal,
            this.MenuItemSetStartSymbol,
            this.MenuItemAddRule,
            this.MenuItemDeleteRule,
            this.MenuItemUpdateRule,
            this.MenuItemDeleteTerminal,
            this.MenuItemDeleteNonTerminal});
            this.contextMenuForUpdateGrammar.Name = "contextMenuForUpdateGrammar";
            this.contextMenuForUpdateGrammar.Size = new System.Drawing.Size(324, 196);
            // 
            // MenuItemAddNonTerminal
            // 
            this.MenuItemAddNonTerminal.Name = "MenuItemAddNonTerminal";
            this.MenuItemAddNonTerminal.Size = new System.Drawing.Size(323, 24);
            this.MenuItemAddNonTerminal.Text = "Добавить нетерминал";
            this.MenuItemAddNonTerminal.Click += new System.EventHandler(this.MenuItemAddNonTerminal_Click);
            // 
            // MenuItemAddTerminal
            // 
            this.MenuItemAddTerminal.Name = "MenuItemAddTerminal";
            this.MenuItemAddTerminal.Size = new System.Drawing.Size(323, 24);
            this.MenuItemAddTerminal.Text = "Добавить терминал";
            this.MenuItemAddTerminal.Click += new System.EventHandler(this.MenuItemAddTerminal_Click);
            // 
            // MenuItemSetStartSymbol
            // 
            this.MenuItemSetStartSymbol.Name = "MenuItemSetStartSymbol";
            this.MenuItemSetStartSymbol.Size = new System.Drawing.Size(323, 24);
            this.MenuItemSetStartSymbol.Text = "Установить стартовый нетерминал";
            this.MenuItemSetStartSymbol.Click += new System.EventHandler(this.MenuItemSetStartSymbol_Click);
            // 
            // MenuItemAddRule
            // 
            this.MenuItemAddRule.Name = "MenuItemAddRule";
            this.MenuItemAddRule.Size = new System.Drawing.Size(323, 24);
            this.MenuItemAddRule.Text = "Добавить правило";
            this.MenuItemAddRule.Click += new System.EventHandler(this.MenuItemAddRule_Click);
            // 
            // MenuItemDeleteRule
            // 
            this.MenuItemDeleteRule.Name = "MenuItemDeleteRule";
            this.MenuItemDeleteRule.Size = new System.Drawing.Size(323, 24);
            this.MenuItemDeleteRule.Text = "Удалить правило";
            this.MenuItemDeleteRule.Click += new System.EventHandler(this.MenuItemDeleteRule_Click);
            // 
            // MenuItemUpdateRule
            // 
            this.MenuItemUpdateRule.Name = "MenuItemUpdateRule";
            this.MenuItemUpdateRule.Size = new System.Drawing.Size(323, 24);
            this.MenuItemUpdateRule.Text = "Изменить правило";
            this.MenuItemUpdateRule.Click += new System.EventHandler(this.MenuItemUpdateRule_Click);
            // 
            // MenuItemDeleteTerminal
            // 
            this.MenuItemDeleteTerminal.Name = "MenuItemDeleteTerminal";
            this.MenuItemDeleteTerminal.Size = new System.Drawing.Size(323, 24);
            this.MenuItemDeleteTerminal.Text = "Удалить терминал";
            this.MenuItemDeleteTerminal.Click += new System.EventHandler(this.MenuItemDeleteTerminal_Click);
            // 
            // MenuItemDeleteNonTerminal
            // 
            this.MenuItemDeleteNonTerminal.Name = "MenuItemDeleteNonTerminal";
            this.MenuItemDeleteNonTerminal.Size = new System.Drawing.Size(323, 24);
            this.MenuItemDeleteNonTerminal.Text = "Удалить нетерминал";
            this.MenuItemDeleteNonTerminal.Click += new System.EventHandler(this.MenuItemDeleteNonTerminal_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.mainMenuStrip.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.грамматикаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1054, 36);
            this.mainMenuStrip.TabIndex = 2;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // грамматикаToolStripMenuItem
            // 
            this.грамматикаToolStripMenuItem.BackColor = System.Drawing.Color.SpringGreen;
            this.грамматикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНетерминалToolStripMenuItem,
            this.добавитьТерминалToolStripMenuItem,
            this.установитьСтартовыйНетерминалToolStripMenuItem,
            this.добавитьПравилоToolStripMenuItem,
            this.удалитьПравилоToolStripMenuItem,
            this.изменитьПравилоToolStripMenuItem,
            this.удалитьТерминалToolStripMenuItem,
            this.удалитьНетерминалToolStripMenuItem});
            this.грамматикаToolStripMenuItem.Name = "грамматикаToolStripMenuItem";
            this.грамматикаToolStripMenuItem.Size = new System.Drawing.Size(143, 32);
            this.грамматикаToolStripMenuItem.Text = "Автомат 2";
            // 
            // добавитьНетерминалToolStripMenuItem
            // 
            this.добавитьНетерминалToolStripMenuItem.Name = "добавитьНетерминалToolStripMenuItem";
            this.добавитьНетерминалToolStripMenuItem.Size = new System.Drawing.Size(501, 32);
            this.добавитьНетерминалToolStripMenuItem.Text = "Добавить нетерминал";
            this.добавитьНетерминалToolStripMenuItem.Click += new System.EventHandler(this.MenuItemAddNonTerminal_Click);
            // 
            // добавитьТерминалToolStripMenuItem
            // 
            this.добавитьТерминалToolStripMenuItem.Name = "добавитьТерминалToolStripMenuItem";
            this.добавитьТерминалToolStripMenuItem.Size = new System.Drawing.Size(501, 32);
            this.добавитьТерминалToolStripMenuItem.Text = "Добавить терминал";
            this.добавитьТерминалToolStripMenuItem.Click += new System.EventHandler(this.MenuItemAddTerminal_Click);
            // 
            // установитьСтартовыйНетерминалToolStripMenuItem
            // 
            this.установитьСтартовыйНетерминалToolStripMenuItem.Name = "установитьСтартовыйНетерминалToolStripMenuItem";
            this.установитьСтартовыйНетерминалToolStripMenuItem.Size = new System.Drawing.Size(501, 32);
            this.установитьСтартовыйНетерминалToolStripMenuItem.Text = "Установить стартовый нетерминал";
            this.установитьСтартовыйНетерминалToolStripMenuItem.Click += new System.EventHandler(this.MenuItemSetStartSymbol_Click);
            // 
            // добавитьПравилоToolStripMenuItem
            // 
            this.добавитьПравилоToolStripMenuItem.Name = "добавитьПравилоToolStripMenuItem";
            this.добавитьПравилоToolStripMenuItem.Size = new System.Drawing.Size(501, 32);
            this.добавитьПравилоToolStripMenuItem.Text = "Добавить правило";
            this.добавитьПравилоToolStripMenuItem.Click += new System.EventHandler(this.MenuItemAddRule_Click);
            // 
            // удалитьПравилоToolStripMenuItem
            // 
            this.удалитьПравилоToolStripMenuItem.Name = "удалитьПравилоToolStripMenuItem";
            this.удалитьПравилоToolStripMenuItem.Size = new System.Drawing.Size(501, 32);
            this.удалитьПравилоToolStripMenuItem.Text = "Удалить правило";
            this.удалитьПравилоToolStripMenuItem.Click += new System.EventHandler(this.MenuItemDeleteRule_Click);
            // 
            // изменитьПравилоToolStripMenuItem
            // 
            this.изменитьПравилоToolStripMenuItem.Name = "изменитьПравилоToolStripMenuItem";
            this.изменитьПравилоToolStripMenuItem.Size = new System.Drawing.Size(501, 32);
            this.изменитьПравилоToolStripMenuItem.Text = "Изменить правило";
            this.изменитьПравилоToolStripMenuItem.Click += new System.EventHandler(this.MenuItemUpdateRule_Click);
            // 
            // удалитьТерминалToolStripMenuItem
            // 
            this.удалитьТерминалToolStripMenuItem.Name = "удалитьТерминалToolStripMenuItem";
            this.удалитьТерминалToolStripMenuItem.Size = new System.Drawing.Size(501, 32);
            this.удалитьТерминалToolStripMenuItem.Text = "Удалить терминал";
            this.удалитьТерминалToolStripMenuItem.Click += new System.EventHandler(this.MenuItemDeleteTerminal_Click);
            // 
            // удалитьНетерминалToolStripMenuItem
            // 
            this.удалитьНетерминалToolStripMenuItem.Name = "удалитьНетерминалToolStripMenuItem";
            this.удалитьНетерминалToolStripMenuItem.Size = new System.Drawing.Size(501, 32);
            this.удалитьНетерминалToolStripMenuItem.Text = "Удалить нетерминал";
            this.удалитьНетерминалToolStripMenuItem.Click += new System.EventHandler(this.MenuItemDeleteNonTerminal_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.BackColor = System.Drawing.Color.SpringGreen;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(117, 32);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // buttonGrammarToStateMachine
            // 
            this.buttonGrammarToStateMachine.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonGrammarToStateMachine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGrammarToStateMachine.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGrammarToStateMachine.Location = new System.Drawing.Point(509, 75);
            this.buttonGrammarToStateMachine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGrammarToStateMachine.Name = "buttonGrammarToStateMachine";
            this.buttonGrammarToStateMachine.Size = new System.Drawing.Size(53, 672);
            this.buttonGrammarToStateMachine.TabIndex = 3;
            this.buttonGrammarToStateMachine.Text = "->";
            this.buttonGrammarToStateMachine.UseVisualStyleBackColor = false;
            this.buttonGrammarToStateMachine.Click += new System.EventHandler(this.buttonGrammarToStateMachine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(170, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Автомат 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(565, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Недетерминированный конечный автомат";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(170, 404);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Автомат 2";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(16, 436);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(484, 311);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.SpringGreen;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.удалитьКонечноеСостояниеToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 32);
            this.toolStripMenuItem2.Text = "Автомат 1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(488, 32);
            this.toolStripMenuItem3.Text = "Добавить состояние";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(488, 32);
            this.toolStripMenuItem4.Text = "Добавить символ алфавита";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(488, 32);
            this.toolStripMenuItem5.Text = "Установить начальное состояние";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(488, 32);
            this.toolStripMenuItem6.Text = "Добавить переход";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(488, 32);
            this.toolStripMenuItem7.Text = "Добавить конечное состояние";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(488, 32);
            this.toolStripMenuItem8.Text = "Удалить состояние";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(488, 32);
            this.toolStripMenuItem9.Text = "Удалить символ алфавита";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(488, 32);
            this.toolStripMenuItem10.Text = "Удалить переход";
            // 
            // удалитьКонечноеСостояниеToolStripMenuItem
            // 
            this.удалитьКонечноеСостояниеToolStripMenuItem.Name = "удалитьКонечноеСостояниеToolStripMenuItem";
            this.удалитьКонечноеСостояниеToolStripMenuItem.Size = new System.Drawing.Size(488, 32);
            this.удалитьКонечноеСостояниеToolStripMenuItem.Text = "Удалить конечное состояние";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1054, 787);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGrammarToStateMachine);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.TextBoxStateMachine);
            this.Controls.Add(this.TextBoxGrammar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "From regular Grammar to State Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuForUpdateGrammar.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBoxGrammar;
        private System.Windows.Forms.RichTextBox TextBoxStateMachine;
        private System.Windows.Forms.ContextMenuStrip contextMenuForUpdateGrammar;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAddNonTerminal;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAddTerminal;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSetStartSymbol;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAddRule;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDeleteRule;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUpdateRule;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDeleteTerminal;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDeleteNonTerminal;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem грамматикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьНетерминалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТерминалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem установитьСтартовыйНетерминалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПравилоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПравилоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьПравилоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьТерминалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьНетерминалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Button buttonGrammarToStateMachine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem удалитьКонечноеСостояниеToolStripMenuItem;
    }
}

