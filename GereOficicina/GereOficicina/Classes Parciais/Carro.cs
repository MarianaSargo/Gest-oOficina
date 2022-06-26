using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereOficicina
{
    public partial class Carro
    {
        public Carro(string matricula)
        {
            this.Matricula = matricula;
            this.Servicos = new HashSet<Servico>();
        }

        public double TotalGasto()
        {
            double total = 0;
            foreach (Servico servico in Servicos)
            {
                total += servico.TotalGasto();
            }
            return total;
        }
        public override string ToString()
        {
            return $"{Matricula} Total Gasto: €{TotalGasto()} ";
        }

    }
}
