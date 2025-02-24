using Automata_Kurs.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automata_Kurs
{
    public partial class Form1 : Form
    {
        DFA dfa1;
        DFA dfa2;

        public Form1()
        {
            dfa1 = new DFA();
            dfa2 = new DFA();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
