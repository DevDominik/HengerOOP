using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Henger
    {
        private double magassag;
        private double sugar;
        private static int szuletesSzamlalo = 0;

        public double GetMagassag {  get { return magassag; } }
        public double GetSugar { get {  return sugar; } }
        public static int SzuletesSzamlalo { get { return szuletesSzamlalo; } }

        public Henger(double sugar, double magassag)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            szuletesSzamlalo++;
        }
        public virtual double Terfogat() { return Math.Round(Math.Pow(this.sugar, 2) * Math.PI * this.magassag, 2); }
        public override string ToString()
        {
            return $"Jellemzők >> térfogat:{Terfogat()}; sugár:{Math.Round(this.sugar, 2)}; magasság:{Math.Round(this.magassag, 2)}";
        }
    }
}