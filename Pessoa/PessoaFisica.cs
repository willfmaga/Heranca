using System;
using System.IO;
using System.Text.Json.Serialization;

namespace Aula
{
    public class PessoaFisica : Pessoa      //teste mudança branch
    {
        public PessoaFisica(string nome, DateTime dataNascimento,
                            string sobrenome, string cpf, string rg, string cordosolhos)
                            : base(nome, dataNascimento, sobrenome, cordosolhos)
        {
            CPF = cpf;
            RG = rg;
        }
        public string CPF { get; private set; }

        public string RG { get; private set; }

    }
}
