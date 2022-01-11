using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;
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
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 1),
                new ContaCorrente(342, 99999),
                new ContaCorrente(340, 57564),
                new ContaCorrente(340, 48950),
                new ContaCorrente(290, 88560),
            };

            //contas.Sort(new ComparadorContaCorrentePorAgencia());
            IOrderedEnumerable<ContaCorrente> contasOrdenadas =
                contas.OrderBy(conta =>
                {
                    if (conta == null)
                    {
                        return int.MaxValue;
                    }
                    return conta.Numero;
                });

            foreach (var conta in contasOrdenadas)
            {
                if (conta != null)
                {
                    Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
                }
            }


            Console.ReadLine();
        }

        static void TestaSort()
        {
            var nomes = new List<string>()
            {
                "Wellington",
                "Guilherme",
                "Luana",
                "Ana"
            };

            nomes.Sort();

            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            Console.ReadLine();

            var idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            idades.AdicionarVarios(45, 89, 12);
            idades.AdicionarVarios(-1, 99);

            idades.Sort();

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

            int[] idades = new int[] { 15, 28, 35, 50, 28, 60 };

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
