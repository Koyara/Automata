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
    public partial class FormAddNonTerminal : Form
    {
        public FormAddNonTerminal()
        {
            InitializeComponent();
        }

        Form1 native_form;

        public FormAddNonTerminal(Form1 form)
        {
            InitializeComponent();
            native_form = form;
        }

        private void buttonAddNonTerminal_Click(object sender, EventArgs e)
        {
            if (textBoxAddNonTerminal.Text == "" || textBoxAddNonTerminal.Text == " " || textBoxAddNonTerminal.Text == "`")
            {
                MessageBox.Show("Нетерминал не может быть задан пробелом, символом '`' и не может быть пустым.");
                return;
            }
            if (native_form.grammar.AddNonTerminal(textBoxAddNonTerminal.Text[0]))
            {
                Close();
                Dispose();
            }
            else MessageBox.Show("Такой нетерминал уже присутствует в грамматике.");
        }
    }
}
