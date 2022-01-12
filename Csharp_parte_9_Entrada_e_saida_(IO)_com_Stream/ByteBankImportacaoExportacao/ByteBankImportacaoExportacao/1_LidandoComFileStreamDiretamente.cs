using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = Encoding.Default;

            var texto = utf8.GetString(buffer, 0, bytesLidos);
            Console.WriteLine(texto);
            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }

        static void LidandoComFileStreamDiretamente()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024];
                var numeroDeBytesLidos = -1;


                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

                    EscreverBuffer(buffer, numeroDeBytesLidos);

                }

            }
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
    }
}