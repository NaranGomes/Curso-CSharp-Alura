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
            string url = "pagina?argumentos";
            string argumentos = url.Substring(7);
            Console.WriteLine(argumentos);
        }
    }
}
