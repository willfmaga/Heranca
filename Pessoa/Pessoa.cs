using Newtonsoft.Json;
using System;
using System.IO;
using System.Text.Json.Serialization;

namespace Aula
{
    public class Pessoa
    {

        const string PATHFILE = @"c:\CADASTRO PESSOAL\CadastroUsuario.txt";
        const string PASTA = @"c:\CADASTRO PESSOAL";
        public Pessoa(string nome, string sobrenome, string nacionalidade, DateTime dataNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Nacionalidade = nacionalidade;
            DataNascimento = dataNascimento;
        }

        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public string Nacionalidade { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public int Idade
        {
            get
            {
                return DateTime.Now.Year - DataNascimento.Year;

            }
        }

        public void Gravar()
        {
            if (!Directory.Exists(PASTA))
            {
                Directory.CreateDirectory(PASTA);
            }

            Console.WriteLine(File.Exists(PATHFILE));
            File.WriteAllText(PATHFILE, "CadastroUsuario");
            Console.WriteLine(File.Exists(PATHFILE));

            //salva em um arquivo de txt
            File.WriteAllText(PATHFILE, JsonConvert.SerializeObject(this) + "\n");

            //ler do arquivo salvo em txt
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            string text = System.IO.File.ReadAllText(@"c:\CADASTRO PESSOAL\CadastroUsuario.txt");
            System.Console.WriteLine("DADOS CARREGADOS DO ARQUIVO PESSOAL = {0}", text);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

        }
    }
}
