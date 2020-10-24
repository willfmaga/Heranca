using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro
{
    public class Cargo
    {
        public Cargo(string nome, string descricao, decimal salario)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Salario = salario;
        }

        public string Nome { get; private set; }

        public string Descricao { get; private set; }

        public decimal Salario { get; private set; }

        public virtual decimal CalculaSalario()
        {
            return Salario;
        }
    }
}
