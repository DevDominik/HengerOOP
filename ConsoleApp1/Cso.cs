using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cso : Henger
    {
        private double falVastagsag;
        public double FalVastagsag => this.falVastagsag;
        public Cso(double sugar, double magassag): base(magassag, sugar)
        {
            this.falVastagsag = 1;
        }
        public Cso(double sugar, double magassag, double falVastagsag): this(magassag, sugar)
        {
            this.falVastagsag = falVastagsag;
        }
        public override double Terfogat()
        {
            return Math.Round(base.Terfogat() - (Math.Pow(base.GetSugar - this.falVastagsag, 2) * Math.PI * base.GetMagassag), 2);
        }
        public override string ToString()
        {
            return $"{base.ToString()}; falvastagság:{this.falVastagsag}";
        }
    }
}
