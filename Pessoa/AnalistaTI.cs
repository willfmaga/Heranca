using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro
{
    class AnalistaTI : Cargo
    {

        public AnalistaTI(string nome, string descricao, decimal salario, int horasExtras) : base(nome, descricao, salario)
        {
            SalarioBase = salario;
            HorasExtras = horasExtras;

        }

        public decimal SalarioBase { get; private set; }

        public decimal HorasExtras { get; private set; }

        public override decimal CalculaSalario()
        {
            decimal salario = (SalarioBase / 30) * HorasExtras;

            return salario;
        }
    }
}
