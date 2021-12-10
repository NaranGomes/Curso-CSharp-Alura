using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando Projeto 10 - Calcula Poupança");

            double valorInvestido = 1000;

            Console.WriteLine("Investindo R$ " + valorInvestido + " com juros de 0.36%");
            int mes = 1;
            while (mes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + mes + " mês(meses) você terá: R$" + valorInvestido );
                mes++;
            }

            //0.36% = 0.0036
             
            Console.ReadLine();
        }
    }
}
