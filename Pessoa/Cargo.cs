using System;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace Cadastro
{
    public class Cargo
    {
        const string PATHFILE = @"c:\CADASTROFUNCIONARIO\CadastroFuncionario.txt";
        const string PASTA = @"c:\CADASTROFUNCIONARIO";
        public Cargo(string nome, string descricao, decimal salario)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Salario = salario;
           
        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
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
        }
    }
}
