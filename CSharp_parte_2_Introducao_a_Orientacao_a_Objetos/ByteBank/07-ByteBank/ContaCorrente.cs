using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class ContaCorrente
    {
        public static int TotaldeContasCriadas { get; private set; }
        public Cliente Titular { get; set; }

        public int _agencia;
        public int Agencia
        { 
            get 
            { 
                return _agencia;
            }
            set
            {
                if (value <=0)
                {
                    return;
                }
                _agencia = value;
            }
        }
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

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotaldeContasCriadas++;
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
