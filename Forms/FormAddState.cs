using FormalLanguagesApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormAddState : Form
    {
        Form1 native_form;
        public FormAddState()
        {
            InitializeComponent();
        }

        private void buttonAddNonTerminal_Click(object sender, EventArgs e)
        {
            if (textBoxAddNonTerminal.Text == "" || textBoxAddNonTerminal.Text == " " || textBoxAddNonTerminal.Text == "`")
            {
                MessageBox.Show("Нетерминал не может быть задан пробелом, символом '`' и не может быть пустым.");
                return;
            }
            if (!native_form.dfa1.States.Contains(textBoxAddNonTerminal.Text))
            {
                native_form.dfa1.AddState(textBoxAddNonTerminal.Text);
                Close();
                Dispose();
            }
            else MessageBox.Show("Такой нетерминал уже присутствует в грамматике.");
        }
    }
}
