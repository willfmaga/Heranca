using Cadastro;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Aula
{
    class Program
    {
        static void Main()
        {
            CadastroPessoal();

            CadastroCargo();

            Console.ReadKey();
        }

        private static void CadastroCargo()
        {
            Escrever("***Bem vindo ao sistema de cadastro Cargos e Salário!***");
            Escrever("----------------------------");
            Escrever("Digite o Cargo Exercido:");
            Escrever("----------------------------");
            Escrever("1 - Vendedor");
            Escrever("2 - ADM");
            Escrever("3 - Analista TI");
            Escrever("----------------------------");
            Escrever("4 - Sair");
            Escrever("5 - Ir Para Cadastro Pessoal");
            Escrever("----------------------------");


            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    CadastroVendedorCompleto();
                    break;

                case "2":
                    CadastroADMCompleto();
                    break;

                case "3":
                    CadastroAnalistaTICompleto();

                    break;
                case "4":
                     {
                        Console.Clear();
                        Console.WriteLine("Aplicação sendo encerrada, digite uma tecla para finalizar.");
                        Environment.Exit(0);
                     }
                    break;

                case "5":
                    Console.Clear();
                    CadastroPessoal();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("***Cargo Não Cadastrado!***");
                    break;
            }
            CadastroCargo();
        }
        private static void CadastroVendedorCompleto()
        {
            Escrever("Digite o Nome do Cargo:");
            string nome = Console.ReadLine();
            nome = nome.ToUpper();

            Escrever("Digite a Descrição do Cargo:");
            string descricao = Console.ReadLine();
            descricao = descricao.ToUpper();

            Escrever("Digite o Salário");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            Escrever("Digite o Total de Vendas deste Mês:");
            decimal totalVendas = Convert.ToDecimal(Console.ReadLine());

            Escrever("Digite a Porcentagem Ganha por Vendas:");
            decimal porc = Convert.ToDecimal(Console.ReadLine());

            Vendedor vend = new Vendedor(nome, descricao, salario, totalVendas, porc);

            Escrever("Seu Salário Este Mês Mais Comissão Será de:");
            Escrever(vend.CalculaSalario().ToString());
            vend.Gravar();

        }

        private static void CadastroADMCompleto()
        {
            Escrever("Digite o Nome do Cargo:");
            string nome = Console.ReadLine();
            nome = nome.ToUpper();

            Escrever("Digite a Descrição do Cargo:");
            string descricao = Console.ReadLine();
            descricao = descricao.ToUpper();

            Escrever("Digite o Salário:");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            Escrever("Se faltou, digite a quantidae de dias:");
            int diasFalta = Convert.ToInt32(Console.ReadLine());

            ADM adm = new ADM(nome, descricao, salario, diasFalta);
            
            Escrever("Seu Salário Este Mês Será de:");
            Escrever(adm.CalculaSalario().ToString());
            adm.Gravar();

        }

        private static void CadastroAnalistaTICompleto()
        {
            Escrever("Digite o Nome do Cargo:");
            string nome = Console.ReadLine();
            nome = nome.ToUpper();
            
            Escrever("Digite a Descrição do Cargo:");
            string descricao = Console.ReadLine();
            descricao = descricao.ToUpper();

            Escrever("Digite o Salário:");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            Escrever("Digite o Total de Horas Extras Feitas este Mês:");
            int horasExtras = Convert.ToInt32(Console.ReadLine());

            Escrever("Digite o Total de Dias Trabalhados este Mês:");
            int diasTrabalhados = Convert.ToInt32(Console.ReadLine());

            AnalistaTI TI = new AnalistaTI(nome, descricao, salario, horasExtras, diasTrabalhados);
            
            Escrever("Seu Salário Este Mês Mais Horas Extras Será de:");
            Escrever(TI.CalculaSalario().ToString());
            TI.Gravar();

        }

        private static void CadastroPessoal()
        {
            Escrever("***Bem vindo ao sistema de cadastro de Pessoal!***");
            Escrever("---------------------------");
            Escrever("Escolha uma das opcoes:");
            Escrever("---------------------------");
            Escrever("1 - Pessoa");
            Escrever("2 - Pessoa Juridica");
            Escrever("3 - Pessoa Fisica");
            Escrever("---------------------------");
            Escrever("4 - Sair");
            Escrever("5 - Ir Para Cadastro Cargos");
            Escrever("---------------------------");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    {
                        CadastroPessoaCompleto();
                    }
                    break;
                case "2":
                    {
                        CadastroPessoaJuridicaCompleto();
                    }
                    break;

                case "3":
                    { 
                    CadastroPessoaFisicaCompleto();
                    }
                    break;

                case "4":
                    {
                        Console.Clear();
                        Console.WriteLine("Aplicação sendo encerrada, digite uma tecla para finalizar.");
                        Environment.Exit(0);
                    }
                    break;


                case "5":
                    Console.Clear();
                    CadastroCargo();
                    break;
            }

            if (escolha != "1" && escolha != "2" && escolha != "3")
            {
                Console.Clear();
                Console.WriteLine("***Opção Inválida!***");
                CadastroPessoal();
            }
        }
        private static void CadastroPessoaFisicaCompleto()
        {
            Escrever("Digite seu nome:");
            string n = Console.ReadLine();
            n = n.ToUpper();

            Escrever("Digite seu sobrenome:");
            string sobrenome = Console.ReadLine();
            sobrenome = sobrenome.ToUpper();

            Escrever("Digite sua Data de Nascimento:");
            DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

            Escrever("Digite sua Nacionalidade:");
            string nacionalidade = Console.ReadLine();
            nacionalidade = nacionalidade.ToUpper();

            Escrever("Digite o RG:");
            string rg = Console.ReadLine();
            rg = rg.ToUpper();
            
            Escrever("Digite o CPF:");
            string cpf = Console.ReadLine();
            cpf = cpf.ToUpper();

            PessoaFisica pf = new PessoaFisica(n, dtnascimento, sobrenome, cpf, rg, nacionalidade);

            pf.Gravar();
        }

        private static void CadastroPessoaJuridicaCompleto()
        {
            Escrever("Digite seu nome:");
            string n = Console.ReadLine();
            n = n.ToUpper();

            Escrever("Digite seu sobrenome:");
            string sobrenome = Console.ReadLine();
            sobrenome = sobrenome.ToUpper();

            Escrever("Digite sua Data de Nascimento:");
            DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

            Escrever("Digite sua Nacionalidade:");
            string nacionalidade = Console.ReadLine();
            nacionalidade = nacionalidade.ToUpper();

            Escrever("Digite o CNPJ:");
            string cnpj = Console.ReadLine();
            cnpj = cnpj.ToUpper();

            PessoaJuridica pj = new PessoaJuridica(n, dtnascimento, sobrenome, cnpj, nacionalidade);

            pj.Gravar();
        }

        private static void CadastroPessoaCompleto()
        {
            Escrever("Digite seu nome");
            string n = Console.ReadLine();
            n = n.ToUpper();

            Escrever("Digite seu sobrenome");
            string sobrenome = Console.ReadLine();
            sobrenome = sobrenome.ToUpper();
            
            Escrever("Digite sua Data de Nascimento");
            DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

            Escrever("Digite sua Nacionalidade:");
            string nacionalidade = Console.ReadLine();
            nacionalidade = nacionalidade.ToUpper();
          
            Pessoa pes = new Pessoa(n, dtnascimento, sobrenome, nacionalidade);

            pes.Gravar();
        }

        static void Escrever(string mensagemParaPrintarNaTela)
        {
            Console.WriteLine(mensagemParaPrintarNaTela);
        }

    }

}
