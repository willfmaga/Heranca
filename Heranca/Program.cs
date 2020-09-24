using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {

            PessoaJuridica pessoaJuridica = new PessoaJuridica("William", 
                                                                new DateTime(1980, 5, 8), 
                                                                "Magalhaes", 
                                                                "456789000001-03",
                                                                "verde");
            

            Console.WriteLine($"Nome: {pessoaJuridica.Nome}");
            Console.WriteLine($"CNPJ: {pessoaJuridica.CNPJ}");
            Console.WriteLine($"Cor dos olhos: {pessoaJuridica.CorDosOlhos}");

            Console.ReadKey();
        }
    }

}
