using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormalLanguagesApp
{
    public partial class FormDeleteNonTerminal : Form
    {
        public FormDeleteNonTerminal()
        {
            InitializeComponent();
        }

        public FormDeleteNonTerminal(Form1 form)
        {
            InitializeComponent();
            native_form = form;
        }

        Form1 native_form;


        private void FormDeleteNonTerminal_Load(object sender, EventArgs e)
        {
            comboBoxDeleteNonTerminal.DataSource = native_form.grammar.NonTerminals;
        }

        private void buttonDeleteNonTerminal_Click(object sender, EventArgs e)
        {
            if (comboBoxDeleteNonTerminal.Text == "" || comboBoxDeleteNonTerminal.Text == " ")
            {
                MessageBox.Show("Терминал не может быть задан пробелом, символом '`', и не может быть пустым.");
                return;
            }
            if (native_form.grammar.DeleteSymbol(comboBoxDeleteNonTerminal.Text[0]))
            {
                Close();
                Dispose();
            }
            else MessageBox.Show("Такого терминала нет в грамматике.");
        }
    }
}
