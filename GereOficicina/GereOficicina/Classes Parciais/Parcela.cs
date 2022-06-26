using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereOficicina
{
    public partial class Parcela
    {
        public Parcela()
        {

        }
        public Parcela(string descricao, double valor)
        {
            this.Descricao = descricao;
            this.Valor = valor; 
        }
        public override string ToString()
        {
            return $"€{Valor} - {Descricao}";
        }
    }
}
