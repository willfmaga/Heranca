using Cadastro;
using System;

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
            Escrever("Digite o Cargo Exercido ou Informações dos Cargos Exercidos............:");
            Escrever("1 - Vendedor");
            Escrever("2 - ADM");
            Escrever("3 - Analista TI");

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
                
                default:
                    Escrever("Cargo nao cadastrado.");
                    break;
            }
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

            Escrever("Seu Salário Este Mês Mais Comissão Será de................:");
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

            Escrever("Digite os Dias Trabalhados");
            int diasFalta = Convert.ToInt32(Console.ReadLine());

            ADM adm = new ADM(nome, descricao, salario, diasFalta);
            
            Escrever("Seu Salário Este Mês Será de................:");
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
            
            Escrever("Seu Salário Este Mês Mais Horas Extras Será de................:");
            Escrever(TI.CalculaSalario().ToString());
            TI.Gravar();
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
            n = n.ToUpper();

            Escrever("Digite seu sobrenome");
            string sobrenome = Console.ReadLine();
            sobrenome = sobrenome.ToUpper();

            Escrever("Digite seu Data Nascimento");
            DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

            Escrever("Digite a cor dos seus olhos");
            string olhos = Console.ReadLine();
            olhos = olhos.ToUpper();

            Escrever("Digite o RG");
            string rg = Console.ReadLine();
            rg = rg.ToUpper();
            
            Escrever("Digite o CPF");
            string cpf = Console.ReadLine();
            cpf = cpf.ToUpper();

            PessoaFisica pf = new PessoaFisica(n, dtnascimento, sobrenome, cpf, rg, olhos);

            pf.Gravar();
        }

        private static void CadastroPessoaJuridicaCompleto()
        {
            Escrever("Digite seu nome");
            string n = Console.ReadLine();
            n = n.ToUpper();

            Escrever("Digite seu sobrenome");
            string sobrenome = Console.ReadLine();
            sobrenome = sobrenome.ToUpper();

            Escrever("Digite seu Data Nascimento");
            DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

            Escrever("Digite a cor dos seus olhos");
            string olhos = Console.ReadLine();
            olhos = olhos.ToUpper();

            Escrever("Digite o CNPJ");
            string cnpj = Console.ReadLine();
            cnpj = cnpj.ToUpper();

            PessoaJuridica pj = new PessoaJuridica(n, dtnascimento, sobrenome, cnpj, olhos);

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

            Escrever("Digite seu Data Nascimento");
            DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

            Escrever("Digite a cor dos seus olhos");
            string olhos = Console.ReadLine();
            olhos = olhos.ToUpper();

            Pessoa pes = new Pessoa(n, dtnascimento, sobrenome, olhos);

            pes.Gravar();
        }

        static void Escrever(string mensagemParaPrintarNaTela)
        {
            Console.WriteLine(mensagemParaPrintarNaTela);
        }
    }
}
