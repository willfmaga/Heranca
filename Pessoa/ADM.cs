using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro
{
    public class ADM : Cargo
    {
        public ADM(string nome, string descricao, decimal salario, int diasFalta) : base(nome, descricao, salario)
        {
            DiasFalta = diasFalta;
        }

        public int DiasFalta { get;private set; }

        public override decimal CalculaSalario()
        {
            decimal valorADescontar = (Salario / 30) * DiasFalta;

            decimal salario = Salario - valorADescontar;

            return salario;
        }

    }
}
