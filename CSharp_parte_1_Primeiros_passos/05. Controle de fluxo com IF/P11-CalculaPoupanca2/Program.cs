using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando Projeto 11 - Calcula Poupança2");

            double valorInvestido = 1000;

            Console.WriteLine("Investindo R$ " + valorInvestido + " com juros de 0.36%");
            
            for (int i = 1; i <= 12; i++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + i + " mês(meses) você terá: R$" + valorInvestido);
                
            }

            //0.36% = 0.0036

            Console.ReadLine();
        }
    }
}
