using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms;
using Forms.Library;

namespace FormalLanguagesApp
{
    public partial class Form1 : Form
    {
        public Grammar grammar;
        public Grammar grammar2;


        public DFA dfa1;
        public DFA dfa2;

        public Form1()
        {
            InitializeComponent();
            grammar = new Grammar();
            grammar2 = new Grammar();

            dfa1 = new DFA();
            dfa2 = new DFA();

            TextBoxGrammar.ContextMenuStrip = contextMenuForUpdateGrammar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void MenuItemAddNonTerminal_Click(object sender, EventArgs e)
        {
            FormAddNonTerminal formAddNonTerminal = new FormAddNonTerminal(this);
            formAddNonTerminal.ShowDialog();
            TextBoxGrammar.Text = grammar.ToString();
        }

        private void MenuItemAddTerminal_Click(object sender, EventArgs e)
        {
            FormAddTerminal formAddTerminal = new FormAddTerminal(this);
            formAddTerminal.ShowDialog();
            TextBoxGrammar.Text = grammar.ToString();
        }

        private void MenuItemSetStartSymbol_Click(object sender, EventArgs e)
        {
            FormSetStartSymbol formSetStartSymbol = new FormSetStartSymbol(this);
            formSetStartSymbol.ShowDialog();
            TextBoxGrammar.Text = grammar.ToString();
        }

        private void MenuItemAddRule_Click(object sender, EventArgs e)
        {
            if(grammar.Terminals.Count == 0)
            {
                MessageBox.Show("Для начала добавьте хотя бы один терминал.");
                return;
            }
            if (grammar.NonTerminals.Count == 0)
            {
                MessageBox.Show("Для начала добавьте хотя бы один нетерминал.");
                return;
            }
            FormAddRule formSetStartSymbol = new FormAddRule(this);
            formSetStartSymbol.ShowDialog();
            TextBoxGrammar.Text = grammar.ToString();
        }

        private void MenuItemDeleteRule_Click(object sender, EventArgs e)
        {
            if(grammar.Rules.RuleSets.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы одно правило.");
                return;
            }
            FormDeleteRule formDeleteRule = new FormDeleteRule(this);
            formDeleteRule.ShowDialog();
            TextBoxGrammar.Text = grammar.ToString();
        }

        private void MenuItemUpdateRule_Click(object sender, EventArgs e)
        {
            if (grammar.Rules.RuleSets.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы одно правило.");
                return;
            }
            FormUpdateRule formUpdateRule = new FormUpdateRule(this);
            formUpdateRule.ShowDialog();
            TextBoxGrammar.Text = grammar.ToString();
        }

        private void MenuItemDeleteTerminal_Click(object sender, EventArgs e)
        {
            if (grammar.Terminals.Count == 0)
            {
                MessageBox.Show("Для начала добавьте хотя бы один терминал.");
                return;
            }
            FormDeleteTerminal formDeleteTerminal = new FormDeleteTerminal(this);
            formDeleteTerminal.ShowDialog();
            TextBoxGrammar.Text = grammar.ToString();
        }

        private void MenuItemDeleteNonTerminal_Click(object sender, EventArgs e)
        {
            if (grammar.NonTerminals.Count == 0)
            {
                MessageBox.Show("Для начала добавьте хотя бы один нетерминал.");
                return;
            }
            FormDeleteNonTerminal formDeleteNonTerminal = new FormDeleteNonTerminal(this);
            formDeleteNonTerminal.ShowDialog();
            TextBoxGrammar.Text = grammar.ToString();
        }

        private void buttonGrammarToStateMachine_Click(object sender, EventArgs e)
        {
            if (grammar.Terminals.Count == 0) { MessageBox.Show("Добавьте хотя бы один терминал."); return; }
            if (grammar.NonTerminals.Count == 0) { MessageBox.Show("Добавьте хотя бы один нетерминал."); return; }
            if (grammar.StartSymbol == '\0') { MessageBox.Show("Установите стартовый символ."); return; }
            if (grammar.Rules.GetAllRules().Count == 0) { MessageBox.Show("Добавьте хотя бы одно правило."); return; }
            try
            {
                StateMachine sm = new StateMachine(grammar);
                if(sm.FiniteStates.Count == 0)
                {
                    MessageBox.Show("Внимание! Данный недетерминированный автомат не является конечным.");
                }
                TextBoxStateMachine.Text = sm.ToString();
            }
            catch
            {
                MessageBox.Show("Не удалось преобразовать грамматику в недетерминированный конечный автомат.");
                return;
            }

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReference formReference = new FormReference();
            formReference.ShowDialog();
        }

        private void TextBoxGrammar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
    }
}
