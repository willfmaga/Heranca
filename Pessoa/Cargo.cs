using System;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace Cadastro
{
    public class Cargo
    {
        const string PATHFILE = @"c:\CADASTRO FUNCIONARIO\CadastroFuncionario.txt";
        const string PASTA = @"c:\CADASTRO FUNCIONARIO";

        public Cargo(string nomeDoCargo, string descricao, decimal salario)
        {
            this.NomeDoCargo = nomeDoCargo;
            this.DescricaoDoCargo = descricao;
            this.Salario = salario;
           
        }

        public string NomeDoCargo { get; private set; }

        public string DescricaoDoCargo { get; private set; }

        public decimal Salario { get; private set; }

            public virtual decimal CalculaSalario()
            {
                return Salario;
            }
          
       
        public void Gravar()
        {
            if (!Directory.Exists(PASTA))
            {
                Directory.CreateDirectory(PASTA);
            }

            Console.WriteLine(File.Exists(PATHFILE));
            File.WriteAllText(PATHFILE, "CadastroFuncionario");
            Console.WriteLine(File.Exists(PATHFILE));

            //salva em um arquivo de txt
            File.WriteAllText(PATHFILE, JsonConvert.SerializeObject(this) + "\n");

            //ler do arquivo salvo em txt
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            string text = System.IO.File.ReadAllText(@"c:\CADASTRO FUNCIONARIO\CadastroFuncionario.txt");
            System.Console.WriteLine("DADOS CARREGADOS DO ARQUIVO FUNCIONÁRIOS = {0}", text);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

        }
    }
}
