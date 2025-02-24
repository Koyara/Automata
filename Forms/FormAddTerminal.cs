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
    public partial class FormAddTerminal : Form
    {
        public FormAddTerminal()
        {
            InitializeComponent();
        }

        Form1 native_form;

        public FormAddTerminal(Form1 form)
        {
            InitializeComponent();
            native_form = form;
        }

        private void buttonAddTerminal_Click(object sender, EventArgs e)
        {
            if(textBoxAddTerminal.Text == "" || textBoxAddTerminal.Text == " " || textBoxAddTerminal.Text == "`")
            {
                MessageBox.Show("Терминал не может быть задан пробелом, символом '`' и не может быть пустым.");
                return;
            }
            if(native_form.grammar.AddTerminal(textBoxAddTerminal.Text[0]))
            {
                Close();
                Dispose();
            }
            else MessageBox.Show("Такой терминал уже присутствует в грамматике.");
        }

        private void textBoxAddTerminal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
