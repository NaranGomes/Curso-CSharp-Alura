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

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public bool Transferir(double valor, ContaCorrente ContaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            ContaDestino.Depositar(valor);
            return true;
        }
    }
}
