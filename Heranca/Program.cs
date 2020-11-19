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
            Console.Title = "CADASTRO DE PESSOAL, CARGOS E SALÁRIOS";
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            CadastroPessoal();

            CadastroCargo();

            Console.ReadKey();
        }

        private static void CadastroCargo()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Escrever("\t\t\t\t***Bem vindo ao sistema de cadastro Cargos e Salários!***");
            Escrever("------------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
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
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Aplicação sendo encerrada, digite uma tecla para finalizar.");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Environment.Exit(0);
                     }
                    break;

                case "5":
                    Console.Clear();
                    CadastroPessoal();
                    break;

                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("***Cargo Não Cadastrado!***");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("***APERTE ENTER PARA CONTINUAR!***");
            Console.ForegroundColor = ConsoleColor.Black;
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
                
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Escrever("Seu Salário Este Mês Mais Comissão Será de:");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("---------------------");
                Escrever("R$"+ vend.CalculaSalario().ToString());
                Console.WriteLine("---------------------");
                Console.ForegroundColor = ConsoleColor.Magenta;

                vend.Gravar();
            }catch
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("***VENDEDOR: Por Favor! Digite apenas números nos campos (SALÁRIO), (TOTAL DE VENDAS) e (PORCENTAGEM GANHA)***");
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Black;
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

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Escrever("Seu Salário Este Mês Será de:");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("--------------------");
                Escrever("R$" + adm.CalculaSalario().ToString() + ",00");
                Console.WriteLine("--------------------");
                Console.ForegroundColor = ConsoleColor.Magenta;

                adm.Gravar();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("***ADM: Por Favor! Digite apenas números nos campos (SALÁRIO) e (FALTA)***");
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Black;

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

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Escrever("Seu Salário Este Mês Mais Horas Extras Será de:");
                Console.ForegroundColor = ConsoleColor.DarkYellow;   
                Console.WriteLine("-------------------");             
                Escrever("R$" + TI.CalculaSalario().ToString()+",00");
                Console.WriteLine("-------------------");             
                Console.ForegroundColor = ConsoleColor.Magenta;

                TI.Gravar();

            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("***ANALISTA TI: Por Favor! Digite apenas números nos campos (SALÁRIO), (HORAS EXTRAS) e (DIAS TRABALHADOS)***");
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Black;
                CadastroAnalistaTICompleto();
            }
        }

        private static void CadastroPessoal()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Escrever("\t\t\t\t***Bem vindo ao sistema de cadastro de Pessoal!***");
            Escrever("------------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Escrever("Escolha uma das Opções:");
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
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Aplicação sendo encerrada, digite uma tecla para finalizar.");
                        Console.ForegroundColor = ConsoleColor.Black;
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
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("***Opção Inválida!***");
                Console.ForegroundColor = ConsoleColor.Black;

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("***APERTE ENTER PARA CONTINUAR!***");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.ReadKey();
                Console.Clear();

                CadastroPessoal();
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("***APERTE ENTER PARA CONTINUAR!***");
            Console.ForegroundColor = ConsoleColor.Black;
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
                rg = rg.ToUpper();

                Escrever("Digite o CPF:");
                string cpf = Console.ReadLine();
                cpf = cpf.ToUpper();

                PessoaFisica pf = new PessoaFisica(n, sobrenome, cpf, rg, nacionalidade, dtnascimento);

                    pf.Gravar();

            }
            catch

            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("***CADASTRO PESSOA FÍSICA: Por Favor! Digite um Formato 'DATA' correto no campo (DATA DE NASCIMENTO)" +
                    " Utilize entre DIA, MÊS e ANO OS FORMATOS: ( /, -, OU, 01 de janeiro de 1900)***");
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Black;
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
                cnpj = cnpj.ToUpper();
                
                
               
                PessoaJuridica pj = new PessoaJuridica(n, sobrenome, nacionalidade, cnpj, dtnascimento);

                    pj.Gravar();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("***CADASTRO PESSOA JURÍDICA: Por Favor! Digite um Formato 'DATA' correto no campo (DATA DE NASCIMENTO)" +
                    " Utilize entre DIA, MÊS e ANO OS FORMATOS: ( /, -, OU, 01 de janeiro de 1900)***");
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Black;
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
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("***CADASTRO PESSOAL: Por Favor! Digite um Formato 'DATA' correto no campo (DATA DE NASCIMENTO)" +
                    " Utilize entre DIA, MÊS e ANO OS FORMATOS: ( /, -, OU, 01 de janeiro de 1900)***");
                Escrever("------------------------------------------------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Black;
                CadastroPessoaCompleto();
            }
        }

        static void Escrever(string mensagemParaPrintarNaTela)
        {
            Console.WriteLine(mensagemParaPrintarNaTela);
        }

       

    }
}
