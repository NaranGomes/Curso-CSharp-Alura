﻿using ByteBank.Modelos;
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
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(123, 2345234),
                new ContaCorrente(123, 2674534),
                new ContaCorrente(123, 2674236)
            };
                        
            for (int i = 0; i < contas.Length; i++)
            {
                ContaCorrente contaAtual = contas[i];
                Console.WriteLine($"Conta {i} {contaAtual.Numero}");
            }

            Console.ReadLine();

        }

        static void TestaArrayInt()
        {
            //Vetor de object só pra testar
            //object[] qualquer = { 0, 2,"aula",2.5};
            //
            //
            //for (int i = 0; i < qualquer.Length; i++)
            //{
            //    Console.WriteLine(qualquer[i]);
            //}

            //Array de inteiros com 5 posições
            //int[] idades = null;
            //idades = new int[6];
            //
            //idades[0] = 15;
            //idades[1] = 28;
            //idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 60;

            int[] idades = new int[] {15, 28, 35, 50, 28, 60};

            int idadeDoIndice4 = idades[4];

            Console.WriteLine(idadeDoIndice4);

            int acumulador = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                int idade = idades[i];
                acumulador += idade;
                Console.WriteLine($"Idade no Indice {i} é igual a {idades[i]}");
            }

            int media = acumulador / idades.Length;
            Console.WriteLine("Média: " + media);

            int[] outroArray = idades;
            Console.WriteLine(outroArray[3]);

            bool[] arrayDeBooleanos = new bool[10];

            arrayDeBooleanos[0] = true;
            arrayDeBooleanos[1] = false;
            arrayDeBooleanos[2] = false;
        }
    }
}
