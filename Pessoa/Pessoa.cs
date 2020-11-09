using Newtonsoft.Json;
using System;
using System.IO;
using System.Text.Json.Serialization;
using System.Globalization;

namespace Aula
{
    public class Pessoa
    {

        const string PATHFILE = @"c:\CADASTRO PESSOAL\CadastroUsuario.txt";
        const string PASTA = @"c:\CADASTRO PESSOAL";
        public Pessoa(string nome,  string sobrenome, string nacionalidade, DateTime dataNascimento)
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
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            string text = System.IO.File.ReadAllText( @"c:\CADASTRO PESSOAL\CadastroUsuario.txt");
            System.Console.WriteLine("DADOS CARREGADOS DO ARQUIVO PESSOAL = {0}", text);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

        }

        public class ConversionToDateTime                                      //tentando acertar o Try Catch para tratar Excessões com as conversões do DateTime.Convert
        {
            public static void ConvertToDateTime(string dtnascimento)
            {
                DateTime convertedDate;
                try
                {
                    convertedDate = Convert.ToDateTime(dtnascimento);
                    Console.WriteLine("'{0}' converter para {1} {2} time.",
                                      dtnascimento, convertedDate,
                                      convertedDate.Kind.ToString());

                    string dateString = null;

                    // Converte um null string.
                    ConvertToDateTime(dateString);

                    // Converte um empty string.
                    dateString = String.Empty;
                    ConvertToDateTime(dateString);

                    // Converte um non-date string.
                    dateString = "não é uma data";
                    ConvertToDateTime(dateString);

                    // Tentativa de converter varios date strings.
                    dateString = "05/01/1996";
                    ConvertToDateTime(dateString);
                    dateString = "Tue Apr 28, 2009";
                    ConvertToDateTime(dateString);
                    dateString = "Wed Apr 28, 2009";
                    ConvertToDateTime(dateString);
                    dateString = "06 July 2008 7:32:47 AM";
                    ConvertToDateTime(dateString);
                    dateString = "17:32:47.003";
                    ConvertToDateTime(dateString);
                    // Converte uma string returnado pelo DateTime.ToString("R").
                    dateString = "Sat, 10 May 2008 14:32:17 GMT";
                    ConvertToDateTime(dateString);
                    // Converte uma string retornado pelo DateTime.ToString("o").
                    dateString = "2009-05-01T07:54:59.9843750-04:00";
                    ConvertToDateTime(dateString);
                }
                catch (FormatException DateTime)
                {
                    Console.WriteLine("'{0}' A Data não está no formato adequado.", DateTime.Message);
                }
            }
        }
    }
}
