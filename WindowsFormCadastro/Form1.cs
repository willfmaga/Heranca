using Aula;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PessoaFisica pessoaFisica = new PessoaFisica(textBox1.Text,
                                                         Convert.ToDateTime(textBox2.Text),
                                                         textBox3.Text,
                                                         textBox4.Text, 
                                                         textBox5.Text,
                                                         textBox6.Text)                                                         );
        }
    }
}
