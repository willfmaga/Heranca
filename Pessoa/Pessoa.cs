using Newtonsoft.Json;
using System;
using System.IO;
using System.Text.Json.Serialization;

namespace Aula
{
    public class Pessoa
    {
        const string PATHFILE = @"c:\CADASTROPESSOAL\CadastroUsuario.txt";
        const string PASTA = @"c:\CADASTROPESSOAL";
        public Pessoa(string nome, DateTime dataNascimento, string sobrenome, string cordosolhos)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Sobrenome = sobrenome;
            CorDosOlhos = cordosolhos;
        }

        public string Nome { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public string Sobrenome { get; private set; }

        public string CorDosOlhos { get; private set; }
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

        }

    }
}
