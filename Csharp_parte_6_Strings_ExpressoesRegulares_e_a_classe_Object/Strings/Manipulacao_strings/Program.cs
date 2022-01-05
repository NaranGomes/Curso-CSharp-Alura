using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Manipulacao_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            Console.ReadLine();
        }

        static void TestaString()
        {
            // Olá, meu nome é Guilherme e você pode entrar em contato comigo
            // através do número 8457-4456!

            // Meu nome é Guilherme, me ligue em 4784-4546

            //string padrao ="[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //string padrao ="[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padrao = "[0-9]{4,5}[-][0-9]{4}";
            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";

            string textoDeTeste = "Meu nome é Guilherme, me ligue em 4784-4546";
            string textoDeTeste2 = "Meu nome é Guilherme, me ligue em 981844546";

            //Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));
            Match resultado = Regex.Match(textoDeTeste, padrao);
            Console.WriteLine(resultado.Value);

            resultado = Regex.Match(textoDeTeste2, padrao);

            //Console.WriteLine(resultado); Dá no mesmo!
            Console.WriteLine(resultado.Value);


            Console.ReadLine();

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
