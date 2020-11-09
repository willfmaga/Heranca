using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro
{
    public class AnalistaTI : Cargo
    {

        public AnalistaTI(string nomeDoCargo, string descricao, decimal salario, int horasExtras, int diasTrabalhados) 
            : base(nomeDoCargo, descricao, salario)
            
        {
            NomeDoCargo = nomeDoCargo;
            DescricaoDoCargo = descricao;
            HorasExtras = horasExtras;
            DiasTrabalhados = diasTrabalhados;
            Salario = salario;
           
        }
        public string NomeDoCargo { get; private set; }
        public string DescricaoDoCargo { get; private set; }
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
