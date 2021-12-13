using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class ContaCorrente
    {
        public string titular;
        public int agencia;
        public int numero;
        public double saldo = 100;

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            return true;
        }

        public bool Transferir(double valor, ContaCorrente ContaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            ContaDestino.Depositar(valor);
            return true;
        }
    }
}
