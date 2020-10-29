using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro
{
    public class Vendedor:Cargo
    {
        public Vendedor(string nome, string descricao, decimal salario, decimal totalVendas, decimal porcentagem):base(nome, descricao,salario)
        {
            TotalVendas = totalVendas;
            Porcentagem = porcentagem;
           
        }

        public decimal TotalVendas { get; private set; }

        public decimal Porcentagem { get; private set; }

        public override decimal CalculaSalario()
        {
            decimal salario = ((TotalVendas * Porcentagem) / 100) + Salario;

            return salario;

        }
    }
}
