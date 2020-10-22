using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {

            Escrever("Bem vindo ao sistema de cadastro pessoas");

            Escrever("Escolha uma das opcoes:");
            Escrever("");
            Escrever("1 - Pessoa");
            Escrever("2 - Pessoa Juridica");
            Escrever("3 - Pessoa Fisica");

            string escolha = Console.ReadLine();


            if (escolha == "1")
            {
                Escrever("Digite seu nome");
                string n = Console.ReadLine();

                Escrever("Digite seu sobrenome");
                string sobrenome = Console.ReadLine();

                Escrever("Digite seu Data Nascimento");
                DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

                Escrever("Digite a cor dos seus olhos");
                string olhos = Console.ReadLine();

                Pessoa pes = new Pessoa(n, dtnascimento, sobrenome, olhos);

                pes.Gravar();


            }
            else if (escolha == "2")
            {
                Escrever("Digite seu nome");
                string n = Console.ReadLine();

                Escrever("Digite seu sobrenome");
                string sobrenome = Console.ReadLine();

                Escrever("Digite seu Data Nascimento");
                DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

                Escrever("Digite a cor dos seus olhos");
                string olhos = Console.ReadLine();

                Escrever("Digite o CNPJ");
                string cnpj = Console.ReadLine();

                PessoaJuridica pessoaJuridica = new PessoaJuridica(n, dtnascimento, sobrenome, cnpj, olhos);

                pessoaJuridica.Gravar();

            }
            else if (escolha == "3")
            {
                Escrever("Digite seu nome");
                string n = Console.ReadLine();

                Escrever("Digite seu sobrenome");
                string sobrenome = Console.ReadLine();

                Escrever("Digite seu Data Nascimento");
                DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

                Escrever("Digite a cor dos seus olhos");
                string olhos = Console.ReadLine();

                Escrever("Digite o RG");
                string rg = Console.ReadLine();

                Escrever("Digite o CPF");
                string cpf = Console.ReadLine();

                PessoaFisica pf = new PessoaFisica(n, dtnascimento, sobrenome, cpf, rg, olhos);

                pf.Gravar();

            }



        }

        static void Escrever(string mensagemParaPrintarNaTela)
        {
            Console.WriteLine(mensagemParaPrintarNaTela);

        }
    }

}
