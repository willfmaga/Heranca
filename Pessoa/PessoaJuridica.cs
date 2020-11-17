using System;
using System.Collections.Generic;
using System.Text;

namespace Aula
{
    public class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(string nome, string sobrenome, string nacionalidade, string cnpj, DateTime dataNascimento)
                               
                              : base(nome, sobrenome, nacionalidade, dataNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Nacionalidade = nacionalidade;
            CNPJ = cnpj;

        }
        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public string Nacionalidade { get; private set; }

        public string CNPJ { get; private set; }

    }
}
