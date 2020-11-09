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
            CNPJ = cnpj;

        }

        public string CNPJ { get; private set; }

    }
}
