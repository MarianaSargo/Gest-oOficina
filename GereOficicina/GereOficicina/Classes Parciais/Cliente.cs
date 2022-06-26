using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereOficicina
{
    public partial class Cliente
    {
        public Cliente(string nome, string NIF)
        {
            this.Nome = nome;
            this.NIF = NIF;
            this.Carros = new HashSet<Carro>();
        }

        public int TotalCarros()
        {           
            return Carros.Count();
        }
        public override string ToString()
        {
            return $"{Nome}({IdCliente}) - {NIF} Total Carros: {TotalCarros()}";
        }
    }
}
