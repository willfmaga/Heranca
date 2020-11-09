using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro
{
    public class ADM : Cargo
    {
        public ADM(string nomeDoCargo, string descricao, decimal salario, int diasFalta) : base(nomeDoCargo, descricao, salario)
        {
            NomeDoCargo = nomeDoCargo;
            DescricaoDoCargo = descricao;
            DiasFalta = diasFalta;
        }
        public string NomeDoCargo { get; private set; }
        
        public string DescricaoDoCargo { get; private set; }

        public int DiasFalta { get;private set; }

        public override decimal CalculaSalario()
        {
            decimal valorADescontar = (Salario / 30) * DiasFalta;

            decimal salario = Salario - valorADescontar;

            return salario;
        }

    }
}
