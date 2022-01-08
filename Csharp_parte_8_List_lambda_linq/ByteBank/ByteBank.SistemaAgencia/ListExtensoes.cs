﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios(this List<int> listaDeInteiros, params int[] itens)
        {
            foreach (int i in itens)
            {
                listaDeInteiros.Add(i);
            }
        }
    }
}
