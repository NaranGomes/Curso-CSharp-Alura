using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(123, 789456123);
                ContaCorrente conta2 = new ContaCorrente(123, 654321789);

                //conta1.Transferir(1000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                //Console.WriteLine("Informaçõe da INNER EXCEPTION");
                //Console.WriteLine(e.InnerException.Message);
                //Console.WriteLine(e.InnerException.StackTrace);
                
            }
        }

        static void Metodo()
        {
            TestaDivisao(0);
        }
        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
        public static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (Exception e)
            {

                Console.WriteLine("Exceção com o número = " + numero + " e divisor= " + divisor);
                throw;
            }

        }
    }
}
