using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7-Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("É maior de idade. Pode entrar.");
            }
            else
            {
                if(quantidadePessoas >= 2)
                {
                    Console.WriteLine("É menor de idade, mas está acompanhado." +
                        " Pode entrar.");
                }
                else
                {
                    Console.WriteLine("É menor de idade. Não pode entrar.");
                }

            }

            Console.ReadLine();
        }
    }
}
