using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste1
{
    public class Veiculo
    {
        public string Modelo { get; set; }

        public string Placa { get; set; }

        public double Km { get; set; }
        public double Valor { get; set; }

        public virtual double CalculaValor()
        {
            return this.Valor;
        }
       


    }
}
