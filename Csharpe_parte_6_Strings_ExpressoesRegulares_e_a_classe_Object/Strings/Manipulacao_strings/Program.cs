using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulacao_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string urlTeste = "http://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("http://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("http://www.bytebank.com")); //true
            Console.WriteLine(urlTeste.EndsWith("/cambio")); //true
            Console.WriteLine(urlTeste.EndsWith("cambio/")); //False

            Console.WriteLine(urlTeste.Contains("ByteBank")); //False devido ao case sensitive

            string url = "pagina?argumentos";
            int indiceInterrogacao = url.IndexOf('?');
            
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);

            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(urlParametros);

            Console.WriteLine("Moeda de Origem: " + extrator.GetValor("MoEdAOrIgEm"));
            Console.WriteLine("Moeda de Destino: " + extrator.GetValor("mOeDaDeStInO"));
            Console.WriteLine(extrator.GetValor("VaLor"));


        }
    }
}
