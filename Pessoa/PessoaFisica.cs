using System;
using System.IO;
using System.Text.Json.Serialization;

namespace Aula
{
    public class PessoaFisica : Pessoa
    {
        public PessoaFisica(string nome, string sobrenome, string cpf, string rg, string nacionalidade, DateTime dataNascimento)

                            : base(nome, sobrenome, nacionalidade, dataNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cpf;
            RG = rg;


        }
        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public string CPF { get; private set; }

        public string RG { get; private set; }


        private Convesao(string CPF, string RG);


    }

    public class TentativaConversao
    {
        public void Conversao()
        {
            int num=0;
            string CPF = "0123456789x";
            string RG = "0123456789x";
            bool Sucesso;
            Sucesso = int.TryParse(CPF, out num);

            

            if (Sucesso)
            {
                Console.WriteLine("Conversão Bem Sucedida! O Valor do némero é" + num);
            }
            else
            {
                Console.WriteLine("A Conversão Falhou!");
            }

            Sucesso = int.TryParse(RG, out num);

            if(Sucesso)
            {
                Console.WriteLine("Conversão Bem Sucedida! O Valor do némero é" + num);
            }
            else
            {
                Console.WriteLine("A Conversão Falhou!");
            }
        }
    }

}

    



    
   


