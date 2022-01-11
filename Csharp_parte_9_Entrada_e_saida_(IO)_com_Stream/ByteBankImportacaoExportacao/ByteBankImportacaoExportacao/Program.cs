using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var enderecoDoArquivo = "contas.txt";

            var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

            var buffer = new byte[1024];
            var numerosDeBytesLidos = -1;

            while (numerosDeBytesLidos != 0)
            {
                numerosDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }

            Console.ReadLine();
        }

        static void ConteudoDoExercicio()
        {
            var fs = new FileStream("c:/temp/teste.txt", FileMode.Open);

            var buffer = new byte[1024];
            var encoding = Encoding.ASCII;

            var bytesLidos = fs.Read(buffer, 0, 1024);
            var conteudoArquivo = encoding.GetString(buffer, 0, bytesLidos);


            Console.Write(conteudoArquivo);

        }
        static void EscreverBuffer(byte[] buffer)
        {
            var utf8 = Encoding.Default;

            var texto = utf8.GetString(buffer);
            Console.WriteLine(texto);
            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }
    }    
}
