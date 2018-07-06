using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTDD
{
    public class Nota
    {
        public Int32 Valor { get; set; }
        public Int32 Quantidade { get; set; }
        public String Resultado
        {
            get
            {
                return Quantidade > 1 ? $"{Quantidade} Notas de {Valor}" : $"{Quantidade} Nota de {Valor}";
            }
        }
    }
}
