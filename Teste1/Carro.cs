using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste1
{
    public class Carro : Veiculo
    {
        public double Reboque { get; set; }

        public virtual void CalculaReboque()
        {
            this.Reboque = 150;
        }

        public override double CalculaValor()
        {
            double taxa = Valor * 0.05;
            return base.CalculaValor() + taxa;
        }

        public string ImprimeValor()
        {
            return " Valor do carro com taxa: "
                + this.CalculaValor();
        }

    }
}
