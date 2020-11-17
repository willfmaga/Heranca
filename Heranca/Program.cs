using Cadastro;
using System;
using System.IO;
using System.Linq.Expressions;
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
            Escrever("\t\t\t\t***Bem vindo ao sistema de cadastro Cargos e Salários!***");
            Escrever("------------------------------------------------------------------------------------------------------------------------");
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

            Console.WriteLine("***APERTE ENTER PARA CONTINUAR!***");
            Console.ReadKey();
            Console.Clear();

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

            try 
            {
                Escrever("Digite o Salário");
                decimal salario = Convert.ToDecimal(Console.ReadLine());

                Escrever("Digite o Total de Vendas deste Mês:");
                decimal totalVendas = Convert.ToDecimal(Console.ReadLine());

                Escrever("Digite a Porcentagem Ganha por Vendas:");
                decimal porc = Convert.ToDecimal(Console.ReadLine());

                Vendedor vend = new Vendedor(nome, descricao, salario, totalVendas, porc);

                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Escrever("Seu Salário Este Mês Mais Comissão Será de:");
                Console.WriteLine("-------");
                Escrever(vend.CalculaSalario().ToString());
                Console.WriteLine("-------");
                vend.Gravar();
            }catch
            {
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("***VENDEDOR: Por Favor! Digite apenas números nos campos (SALÁRIO), (TOTAL DE VENDAS) e (PORCENTAGEM GANHA)***");
                Escrever("------------------------------------------------------------------------------------------------------------------------");

                CadastroVendedorCompleto();
            }
        }

        private static void CadastroADMCompleto()
        {
            Escrever("Digite o Nome do Cargo:");
            string nome = Console.ReadLine();
            nome = nome.ToUpper();

            Escrever("Digite a Descrição do Cargo:");
            string descricao = Console.ReadLine();
            descricao = descricao.ToUpper();

            try
            {
                Escrever("Digite o Salário:");
                decimal salario = Convert.ToDecimal(Console.ReadLine());

                Escrever("Se faltou, digite a quantidae de dias:");
                int diasFalta = Convert.ToInt32(Console.ReadLine());

                ADM adm = new ADM(nome, descricao, salario, diasFalta);

                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Escrever("Seu Salário Este Mês Será de:");
                Console.WriteLine("-------");
                Escrever(adm.CalculaSalario().ToString());
                Console.WriteLine("-------");

                adm.Gravar();
            }
            catch
            {
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("***ADM: Por Favor! Digite apenas números nos campos (SALÁRIO) e (FALTA)***");
                Escrever("------------------------------------------------------------------------------------------------------------------------");
               
                CadastroADMCompleto();
            }
        }

        private static void CadastroAnalistaTICompleto()
        {
            Escrever("Digite o Nome do Cargo:");
            string nome = Console.ReadLine();
            nome = nome.ToUpper();
            
            Escrever("Digite a Descrição do Cargo:");
            string descricao = Console.ReadLine();
            descricao = descricao.ToUpper();

            try
            {
                Escrever("Digite o Salário:");
                decimal salario = Convert.ToDecimal(Console.ReadLine());

                Escrever("Digite o Total de Horas Extras Feitas este Mês:");
                int horasExtras = Convert.ToInt32(Console.ReadLine());

                Escrever("Digite o Total de Dias Trabalhados este Mês:");
                int diasTrabalhados = Convert.ToInt32(Console.ReadLine());

                AnalistaTI TI = new AnalistaTI(nome, descricao, salario, horasExtras, diasTrabalhados);

                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Escrever("Seu Salário Este Mês Mais Horas Extras Será de:");
                Console.WriteLine("-------");
                Escrever(TI.CalculaSalario().ToString());
                Console.WriteLine("-------");
                TI.Gravar();
            }
            catch
            {
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("***ANALISTA TI: Por Favor! Digite apenas números nos campos (SALÁRIO), (HORAS EXTRAS) e (DIAS TRABALHADOS)***");
                Escrever("------------------------------------------------------------------------------------------------------------------------");

                CadastroAnalistaTICompleto();
            }
        }

        private static void CadastroPessoal()
        {
            Escrever("\t\t\t\t***Bem vindo ao sistema de cadastro de Pessoal!***");
            Escrever("------------------------------------------------------------------------------------------------------------------------");
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
            Console.WriteLine("***APERTE ENTER PARA CONTINUAR!***");
            Console.ReadKey();
            Console.Clear();

            CadastroCargo();
        }
        private static void CadastroPessoaFisicaCompleto()
        {
            Escrever("Digite seu nome:");
            string n = Console.ReadLine();
            n = n.ToUpper();

            Escrever("Digite seu sobrenome:");
            string sobrenome = Console.ReadLine();
            sobrenome = sobrenome.ToUpper();

            try
            {
                Escrever("Digite sua Data de Nascimento:");
                DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

                Escrever("Digite sua Nacionalidade:");
                string nacionalidade = Console.ReadLine();
                nacionalidade = nacionalidade.ToUpper();
               
                    Escrever("Digite o RG:");
                    string rg = Console.ReadLine();

                    Escrever("Digite o CPF:");
                    string cpf = Console.ReadLine();

                    PessoaFisica pf = new PessoaFisica(n, sobrenome, cpf, rg, nacionalidade, dtnascimento);

                    pf.Gravar();

            }
            catch
            {
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("***CADASTRO PESSOA FÍSICA: Por Favor! Digite um Formato 'DATA' correto no campo (DATA DE NASCIMENTO)" +
                    " Utilize entre DIA, MÊS e ANO OS FORMATOS: ( /, -, OU, 01 de janeiro de 1900)***");
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                CadastroPessoaFisicaCompleto();

            }
        }

        private static void CadastroPessoaJuridicaCompleto()
        {
            Escrever("Digite seu nome:");
            string n = Console.ReadLine();
            n = n.ToUpper();

            Escrever("Digite seu sobrenome:");
            string sobrenome = Console.ReadLine();
            sobrenome = sobrenome.ToUpper();

            try
            {
                Escrever("Digite sua Data de Nascimento:");
                DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

                Escrever("Digite sua Nacionalidade:");
                string nacionalidade = Console.ReadLine();
                nacionalidade = nacionalidade.ToUpper();
                
                    Escrever("Digite o CNPJ:");
                    string cnpj = Console.ReadLine();

                PessoaJuridica pj = new PessoaJuridica(n, sobrenome, nacionalidade, cnpj, dtnascimento);

                    pj.Gravar();

            }
            catch
            {
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("***CADASTRO PESSOA JURÍDICA: Por Favor! Digite um Formato 'DATA' correto no campo (DATA DE NASCIMENTO)" +
                    " Utilize entre DIA, MÊS e ANO OS FORMATOS: ( /, -, OU, 01 de janeiro de 1900)***");
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                CadastroPessoaJuridicaCompleto();
            }
        }

        private static void CadastroPessoaCompleto()
        {
            Escrever("Digite seu nome");
            string n = Console.ReadLine();
            n = n.ToUpper();

            Escrever("Digite seu sobrenome");
            string sobrenome = Console.ReadLine();
            sobrenome = sobrenome.ToUpper();

            try
            {
                Escrever("Digite sua Data de Nascimento");
                DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

                Escrever("Digite sua Nacionalidade:");
                string nacionalidade = Console.ReadLine();
                nacionalidade = nacionalidade.ToUpper();

                Pessoa pes = new Pessoa(n, sobrenome, nacionalidade, dtnascimento);

                pes.Gravar();

            }
            catch
            {
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("***CADASTRO PESSOAL: Por Favor! Digite um Formato 'DATA' correto no campo (DATA DE NASCIMENTO)" +
                    " Utilize entre DIA, MÊS e ANO OS FORMATOS: ( /, -, OU, 01 de janeiro de 1900)***");
                Escrever("------------------------------------------------------------------------------------------------------------------------");

                CadastroPessoaCompleto();

            }
        }

        static void Escrever(string mensagemParaPrintarNaTela)
        {
            Console.WriteLine(mensagemParaPrintarNaTela);
        }

    }
}
