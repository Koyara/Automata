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
    public partial class FormDeleteTerminal : Form
    {
        public FormDeleteTerminal()
        {
            InitializeComponent();
        }

        public FormDeleteTerminal(Form1 form)
        {
            InitializeComponent();
            native_form = form;
        }

        Form1 native_form;

        private void buttonDeleteTerminal_Click(object sender, EventArgs e)
        {
            if (comboBoxDeleteTerminal.Text == "" || comboBoxDeleteTerminal.Text == " ")
            {
                MessageBox.Show("Терминал не может быть задан пробелом, символом '`', и не может быть пустым.");
                return;
            }
            if (native_form.grammar.DeleteSymbol(comboBoxDeleteTerminal.Text[0]))
            {
                Close();
                Dispose();
            }
            else MessageBox.Show("Такого терминала нет в грамматике.");
        }

        private void FormDeleteTerminal_Load(object sender, EventArgs e)
        {
            comboBoxDeleteTerminal.DataSource = native_form.grammar.Terminals;
        }
    }
}
