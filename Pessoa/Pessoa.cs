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
        /*
        public class ConversionToDateTime
        {
            public static void Main()
            {
                string dateString = null;

                // Convert a null string.
                ConvertToDateTime(dateString);

                // Convert an empty string.
                dateString = String.Empty;
                ConvertToDateTime(dateString);

                // Convert a non-date string.
                dateString = "not a date";
                ConvertToDateTime(dateString);

                // Try to convert various date strings.
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
                // Convert a string returned by DateTime.ToString("R").
                dateString = "Sat, 10 May 2008 14:32:17 GMT";
                ConvertToDateTime(dateString);
                // Convert a string returned by DateTime.ToString("o").
                dateString = "2009-05-01T07:54:59.9843750-04:00";
                ConvertToDateTime(dateString);
            }
            private static void ConvertToDateTime(string dtnascimento)
            {
                DateTime convertedDate;
                try
                {
                    convertedDate = Convert.ToDateTime(dtnascimento);
                    Console.WriteLine("'{0}' converts to {1} {2} time.",
                                      dtnascimento, convertedDate,
                                      convertedDate.Kind.ToString());
                }
                catch (FormatException)
                {
                    Console.WriteLine("'{0}' is not in the proper format.", dtnascimento);
                }
        
            }
        }

        */
    }
}