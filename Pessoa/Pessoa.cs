using System;

namespace Aula
{
    public class Pessoa
    {
        public Pessoa(string nome, DateTime dataNascimento, string sobrenome, string cordosolhos)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Sobrenome = sobrenome;
            CorDosOlhos = cordosolhos;
        }

        public string Nome { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public string Sobrenome { get; private set; }

        public string CorDosOlhos { get; private set; }
        public int Idade
        {
            get
            {
                return DateTime.Now.Year - DataNascimento.Year;
            }

        }

    }
}
