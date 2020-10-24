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
            
            PessoaFisica pessoaFisicaForm = new PessoaFisica(txtNome.Text,
                                                         Convert.ToDateTime(txtDtNascimento.Text),
                                                         txtSobrenome.Text,
                                                         txtRG.Text,
                                                         txtCPF.Text,
                                                         txtCorOlhos.Text);

            pessoaFisicaForm.Gravar();

        }
    }
}
