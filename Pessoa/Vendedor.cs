using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro
{
    public class Vendedor:Cargo
    {
        public Vendedor(string nomeDoCargo, string descricao, decimal salario, decimal totalVendas, decimal porcentagem):base(nomeDoCargo, descricao,salario)
        {
            NomeDoCargo = nomeDoCargo;
            DescricaoDoCargo = descricao;
            TotalVendas = totalVendas;
            Porcentagem = porcentagem;
           
        }
        public string NomeDoCargo { get; private set; }

        public string DescricaoDoCargo { get; private set; }

        public decimal TotalVendas { get; private set; }

        public decimal Porcentagem { get; private set; }

        public override decimal CalculaSalario()
        {
            decimal salario = ((TotalVendas * Porcentagem) / 100) + Salario;

            return salario;

        }
    }
}
