using System;

namespace Aula
{
    public class PessoaFisica : Pessoa 
    {
        public PessoaFisica(string nome, DateTime dataNascimento, 
                            string sobrenome,string cpf, string rg, string cordosolhos)
                            : base(nome, dataNascimento,sobrenome, cordosolhos)
        {
            CPF = cpf;
            RG = rg;
        }
        public string CPF { get; set; }

        public string RG { get; set; }
    }
}
