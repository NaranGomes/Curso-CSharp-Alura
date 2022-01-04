using ByteBank.Modelos;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Carlos";
            cliente.CPF = "12345678";
            cliente.Profissao = "Designer";
            
            Cliente cliente2 = new Cliente();
            cliente2.Nome = "Carlos";
            cliente2.CPF = "12345678";
            cliente2.Profissao = "Designer";

            ContaCorrente conta = new ContaCorrente(12, 12123);

            if (cliente.Equals(conta))
            {
                Console.WriteLine("São iguais");
            }
            else
            {
                Console.WriteLine("São diferentes");                
            }

            Console.Read();

            DateTime dataFimPagamento = new DateTime(2022, 3, 5);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            Console.WriteLine(diferenca);

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);

        }
    }
}
