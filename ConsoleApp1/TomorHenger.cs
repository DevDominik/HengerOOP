using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class TomorHenger : Henger
    {
        private double fajsuly;

        public double GetFajsuly {  get { return fajsuly; } }
        public double Suly { get { return base.Terfogat() * this.fajsuly; } }

        public TomorHenger(double sugar, double magassag): base(sugar, magassag)
        {
            this.fajsuly = 7.87;
        }
        public TomorHenger(double sugar, double magassag, double fajsuly): base(sugar, magassag)
        {
            this.fajsuly = fajsuly;
        }
        public override string ToString()
        {
            return $"{base.ToString()}; fajsúly:{Math.Round(this.fajsuly, 2)}";
        }
    }
}
