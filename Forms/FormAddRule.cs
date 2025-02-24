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

namespace FormalLanguagesApp
{
    public partial class FormAddRule : Form
    {
        public FormAddRule()
        {
            InitializeComponent();
        }

        public FormAddRule(Form1 form)
        {
            InitializeComponent();
            native_form = form;
        }

        Form1 native_form;

        private void FormAddRule_Load(object sender, EventArgs e)
        {
            List<char> temp_for_nonterminals = new List<char>(native_form.grammar.NonTerminals);
            List<char> temp_for_terminals = new List<char>(native_form.grammar.Terminals);
            temp_for_terminals.Add('`');
            comboBoxMainNonTerminal.DataSource = native_form.grammar.NonTerminals;
            comboBoxNonTerminal.DataSource = temp_for_nonterminals;
            comboBoxTerminal.DataSource = temp_for_terminals;
        }

        private void buttonAddRule_Click(object sender, EventArgs e)
        {
            if(comboBoxMainNonTerminal.Text == "" || comboBoxMainNonTerminal.Text == "`" || comboBoxMainNonTerminal.Text == " ")
            {
                MessageBox.Show("Основной нетерминал должен задаваться символом. Он не может быть пустым и не может задаваться символом '`' и пробелом.");
                return;
            }
            if (comboBoxTerminal.Text == "" || comboBoxTerminal.Text == " ")
            {
                MessageBox.Show("Терминал должен задаваться символом. Он не может быть пустым и не может задаваться пробелом.");
                return;
            }
            if (comboBoxNonTerminal.Text == "`")
            {
                MessageBox.Show("Нетерминал должен задаваться символом. Он не может задаваться символом '`'.");
                return;
            }
            if(native_form.grammar.AddRule(Convert.ToChar(comboBoxMainNonTerminal.Text), comboBoxTerminal.Text + comboBoxNonTerminal.Text))
            {
                Close();
                Dispose();
            }
            else
            {
                MessageBox.Show("Один из символов не содержится в грамматике.");
                return;
            }
        }

        private void comboBoxTerminal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTerminal.Text == "`")
                comboBoxNonTerminal.Text = "";
        }
    }
}
