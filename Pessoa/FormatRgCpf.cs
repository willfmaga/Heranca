using System;
using System.Collections.Generic;
using System.Text;

namespace Aula
{
    class FormatRgCpf : PessoaFisica
    {
        public FormatRgCpf(string nome, string sobrenome, string cpf, string rg, string nacionalidade, DateTime dataNascimento)
                            : base(nome, sobrenome, cpf, rg, nacionalidade, dataNascimento)
        {
            string FormatRG(string RG)
            {
                this.RG = rg;
                PessoaFisica RegGeral = new PessoaFisica(nome, sobrenome, cpf, rg, nacionalidade, dataNascimento);
                {
                    return Convert.ToUInt64(RG).ToString(@"00\.000\.000\-00");
                }
            }

            string FormatCPF(string CPF)
            {
                this.CPF = cpf;
                PessoaFisica RegFederal = new PessoaFisica(nome, sobrenome, cpf, rg, nacionalidade, dataNascimento);
                {
                    return Convert.ToUInt64(CPF).ToString(@"000\.000\.000\-00");
                }

                static string SemFormatacao(string Codigo)
                {
                    return Codigo.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty);
                }
            }

            /*
             
             public static string FormatCNPJ(string CNPJ)
            {
                return Convert.ToUInt64(CNPJ).ToString(@"00\.000\.000\/0000\-00");
            }

            */


           

        }

    }
}
