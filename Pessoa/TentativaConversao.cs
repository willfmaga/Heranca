using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json.Serialization;

namespace Aula

{
    class TentativaConversao : PessoaFisica
    {

        public TentativaConversao(string nome, string sobrenome, string cpf, string rg, string cnpj, string nacionalidade, DateTime dataNascimento, Int64 num)
                             : base(nome, sobrenome, cpf, rg, nacionalidade, dataNascimento)
        {
            
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cpf;
            RG = rg;
            Num = num;
        }

        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public string CPF { get; private set; }

        public string RG { get; private set; }


        public Int64 Num { get; private set; }


        public void ConvertDOCS(string nome, string sobrenome, string cpf, string rg, string cnpj, string nacionalidade, DateTime dataNascimento)

        {
            Int64 num = 0;
            bool Sucesso = false;
            string CPF = "0123456789x";
            string RG = "0123456789x";

            this.Num = num;
            this.CPF = cpf;
            this.RG = rg;

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

    
        
    

