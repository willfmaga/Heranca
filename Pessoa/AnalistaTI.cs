using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro
{
    public class AnalistaTI : Cargo
    {

        public AnalistaTI(string nome, string descricao, decimal salario, int horasExtras, int diasTrabalhados) : base(nome, descricao, salario)
        {
            HorasExtras = horasExtras;
            DiasTrabalhados = diasTrabalhados;
            Salario = salario;

        }

        public int HorasExtras { get; private set; }
        public int DiasTrabalhados { get; private set; }
        public new decimal Salario { get; private set; }

        public override decimal CalculaSalario()
        {
            decimal salario = (Salario/DiasTrabalhados ) * HorasExtras + Salario;

            return salario;
        }
    }
}
