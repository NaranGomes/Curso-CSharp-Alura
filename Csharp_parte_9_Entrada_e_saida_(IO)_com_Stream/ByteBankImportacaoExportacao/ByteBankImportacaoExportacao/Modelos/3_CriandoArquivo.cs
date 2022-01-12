using ByteBankImportacaoExportacao.Modelos;
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
        static void CriarArquivo()
        {

            var caminhoNovoArquivo = "contasExportadas.csv";
            using (var fluxoDeAquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,78945,4785.50,Gustavo Santos";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeAquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";
            using (var fluxoDeAquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))

            using (var escritor = new StreamWriter(fluxoDeAquivo))
            {
                escritor.Write("45,65465,465468.54,Pedro");
            }

        }
    }
}
