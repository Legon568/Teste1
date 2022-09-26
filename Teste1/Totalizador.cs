using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste1
{
    public class Totalizador
    {
        public double TotalValor {get; set;}
        public double Soma(Veiculo veiculo)
        {
            TotalValor += veiculo.CalculaValor();
            return this.TotalValor;
        }
    }
}
