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
    public partial class FormSetStartSymbol : Form
    {
        public FormSetStartSymbol()
        {
            InitializeComponent();
        }

        public FormSetStartSymbol(Form1 form)
        {
            native_form = form;
            InitializeComponent();
        }

        Form1 native_form;

        private void FormSetStartSymbol_Load(object sender, EventArgs e)
        {
            comboBoxStartSymbol.DataSource = native_form.grammar.NonTerminals;
        }

        private void buttonStartSymbol_Click(object sender, EventArgs e)
        {
            if(comboBoxStartSymbol.Text == "" || comboBoxStartSymbol.Text == "`" || comboBoxStartSymbol.Text == " ")
            {
                MessageBox.Show("Стартовый символ не может быть пустым и задаваться символом '`' и пробелом.");
                return;
            }
            if(comboBoxStartSymbol.Text.Length > 1)
            {
                MessageBox.Show("Требуется ввести символ, а не строку.");
                return;
            }
            if (native_form.grammar.InstallStartSymbol(Convert.ToChar(comboBoxStartSymbol.Text)))
            {
                Close();
                Dispose();
            }
            else
                MessageBox.Show("Такой символ уже содержится в списке терминалов. Нельзя назначить терминал стартовым символом.");
        }
    }
}
