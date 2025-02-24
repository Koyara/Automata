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
    public partial class FormDeleteRule : Form
    {
        public FormDeleteRule()
        {
            InitializeComponent();
        }

        public FormDeleteRule(Form1 form)
        {
            InitializeComponent();
            native_form = form;
        }

        Form1 native_form;

        private void FormDeleteRule_Load(object sender, EventArgs e)
        {
            comboBoxRules.DataSource = native_form.grammar.Rules.GetAllRules();
        }

        private void buttonDeleteRule_Click(object sender, EventArgs e)
        {
            if(comboBoxRules.SelectedItem == null)
            {
                MessageBox.Show("Выберите правило которое присутствует в грамматике!");
                return;
            }
            if (native_form.grammar.DeleteRule((Forms.Rule)comboBoxRules.SelectedItem))
            {
                MessageBox.Show("Правило успешно удалено!");
                Close();
                Dispose();
            }
            else
            {
                MessageBox.Show("Такого правила нет в грамматике.");
                return;
            }
        }

        private void comboBoxRules_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
