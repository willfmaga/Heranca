using Cadastro;
using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            CadastroPessoal();

            CadastroCargo();

            Console.ReadKey();
        }

        private static void CadastroCargo()
        {
            Escrever("Digite o cargo");
            Escrever("1 - Vendedor");
            Escrever("2 - ADM");
            Escrever("3 - Analista TI");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    CadastroVendedorCompleto();

                    break;
                default:
                    Escrever("Cargo nao cadastrado.");
                    break;
            }
        }

        private static void CadastroVendedorCompleto()
        {
            Escrever("Digite o Nome cargo");
            string nome = Console.ReadLine();

            Escrever("Digite a Descricao");
            string descricao = Console.ReadLine();

            Escrever("Digite o salario");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            Escrever("Digite a total de vendas");
            decimal totalVendas = Convert.ToDecimal(Console.ReadLine());

            Escrever("Digite a porcentagem");
            decimal porc = Convert.ToDecimal(Console.ReadLine());

            Vendedor vend = new Vendedor(nome, descricao, salario, totalVendas, porc);

            Escrever("Seu salario e :");
            Escrever(vend.CalculaSalario().ToString());
        }

        private static void CadastroPessoal()
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
                CadastroPessoaCompleto();

            }
            else if (escolha == "2")
            {
                CadastroPessoaJuridicaCompleto();

            }
            else if (escolha == "3")
            {
                CadastroPessoaFisicaCompleto();

            }
        }

        private static void CadastroPessoaFisicaCompleto()
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

        private static void CadastroPessoaJuridicaCompleto()
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

        private static void CadastroPessoaCompleto()
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

        static void Escrever(string mensagemParaPrintarNaTela)
        {
            Console.WriteLine(mensagemParaPrintarNaTela);

        }
    }

}
