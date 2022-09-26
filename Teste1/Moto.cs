using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste1
{
    public class Moto : Veiculo
    {
        public double Kit { get; set; }

        public virtual void CalculaKit()
        {
            this.Kit = 145;
        }

        public override double CalculaValor()
        {
            double taxa = Valor * 0.025;
            return base.CalculaValor() + taxa;
        }

        public string ImprimeValor()
        {
            return " Valor da moto com taxa: "
                + this.CalculaValor();
        }
    }
}
