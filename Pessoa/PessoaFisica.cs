using System;
using System.IO;
using System.Text.Json.Serialization;

namespace Aula
{
    public class PessoaFisica : Pessoa
    {
        public PessoaFisica(string nome, string sobrenome, string cpf, string rg, string nacionalidade, DateTime dataNascimento)
                              
                            : base(nome, sobrenome,nacionalidade, dataNascimento)
        {
            CPF = cpf;
            RG = rg;
        }
        public string CPF { get; private set; }

        public string RG { get; private set; }

    }
}
