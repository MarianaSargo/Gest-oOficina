using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereOficicina
{
    public partial class Servico
    {
        public Servico(string tipo)
        {
            this.Tipo = tipo;
            this.Data = DateTime.Now;
            this.Parcelas = new HashSet<Parcela>();
        }

        public double TotalGasto()
        {
            double Total = 0;
            foreach (Parcela parcela in Parcelas )
            {
                Total += parcela.Valor;
               
            }
            return Total;
        }

        public override string ToString()
        {
            return $"{Data} {Tipo} Total: €{TotalGasto()}";
        }

    }
}
