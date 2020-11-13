using System;
using System.IO;
using System.Text.Json.Serialization;

namespace Aula
{
    public class PessoaFisica : Pessoa
    {
        public PessoaFisica(string nome, string sobrenome, int cpf, int rg, string nacionalidade, DateTime dataNascimento)
                              
                            : base(nome, sobrenome,nacionalidade, dataNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cpf;
            RG = rg;
        }
        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public int CPF { get; private set; }

        public int RG { get; private set; }

    }
}
