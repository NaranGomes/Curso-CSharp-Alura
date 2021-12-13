using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoNaran = new ContaCorrente();
            contaDoNaran.titular = "Naran";
            contaDoNaran.Depositar(2200);

            Console.WriteLine(contaDoNaran.saldo);

            ContaCorrente contaDaSamile = new ContaCorrente();
            contaDaSamile.titular = "Samile";
            Console.WriteLine(contaDaSamile.saldo);

            contaDoNaran.Transferir(500, contaDaSamile);
            Console.WriteLine(contaDoNaran.saldo);
            Console.WriteLine(contaDaSamile.saldo);



        }
    }
}
