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

            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            idades.Remove(61);

            int[] range = new int[] {9,8,7,6,5,4,3,2,1};

            idades.AddRange(range);

            ListExtensoes.AdicionarVarios(idades, 10, 20, 30, 40, 50);

            idades.AdicionarVarios(321, 123, 456, 98798);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            Console.ReadLine();

        }
        
        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrentes lista = new ListaDeContaCorrentes();

            ContaCorrente contaDoGui = new ContaCorrente(111, 1111111);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(123, 2345234),
                new ContaCorrente(132, 9879684)

            };

            lista.AdicionarVarios(contas);



            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia} ");
            }

        }
        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int item in numeros)
            {
                acumulador += item;
            }
            return acumulador;
        }
        static void TestaArrayDeContaCorrente()
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
