using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    internal class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

       
        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (Saldo < valor)
            {
                return false;
            }

            Saldo -= valor;
            return true;
        }

        public bool Transferir(double valor, ContaCorrente ContaDestino)
        {
            if (Saldo < valor)
            {
                return false;
            }

            Saldo -= valor;
            ContaDestino.Depositar(valor);
            return true;
        }
    }
}
