using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulacao_strings
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }
        public ExtratorValorDeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento URL não pode ser nulo ou vazio", nameof(url));
            }

            URL = url;
            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring( indiceInterrogacao + 1);
        }

        public string GetValor(string nomeParametro)
        {
            string argumentosEmCaixaAlta = _argumentos.ToUpper();
            nomeParametro = nomeParametro.ToUpper();

            string termo = nomeParametro + "=";
            int indiceTermo = argumentosEmCaixaAlta.IndexOf(termo);
            
            string resultado = _argumentos.Substring( indiceTermo + termo.Length);

            int indexEComercial = resultado.IndexOf('&');
            if (indexEComercial == -1)
            {
                return resultado;
            }
            return resultado.Remove(indexEComercial);
        }
    }
}
