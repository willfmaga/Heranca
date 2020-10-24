using System;
using System.Collections.Generic;
using System.Text;

namespace Aula
{
    public class PessoaJuridica : Pessoa //teste mudença Branch PessoaJuridica
    {
        public PessoaJuridica(string nome, DateTime dataNascimento, 
                              string sobrenome, string cnpj, string cordosolhos) 
                              : base(nome, dataNascimento, sobrenome, cordosolhos)
        {
            CNPJ = cnpj;

        }

        public string CNPJ { get; private set; }

    }
}
