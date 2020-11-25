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
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cpf;
            RG = rg;
        }
        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public string CPF { get; private set; }

        public string RG { get; private set; }

    }

    public class TentativaConversao
    {
        public void Main(string nome, string sobrenome, string cpf, string rg, string nacionalidade, DateTime dataNascimento)
        {
            Int64 num = 0;
            string CPF = "0123456789x";
            string RG = "0123456789x";
            bool Sucesso;

            PessoaFisica RegGeral = new PessoaFisica(nome, sobrenome, cpf, rg, nacionalidade, dataNascimento); 
            PessoaFisica RegFederal = new PessoaFisica(nome, sobrenome, cpf, rg, nacionalidade, dataNascimento);

            Sucesso = Int64.TryParse(CPF, out num);

            if (Sucesso)
            {
                Console.WriteLine("Conversão Bem Sucedida! O Valor do número é" + num);
            }
            else
            {
                Console.WriteLine("A Conversão Falhou!");
            }

            Sucesso = Int64.TryParse(RG, out num);

            if (Sucesso)
            {
                Console.WriteLine("Conversão Bem Sucedida! O Valor do número é" + num);
            }
            else
            {
                Console.WriteLine("A Conversão Falhou!");
            }
        }
    }

}
