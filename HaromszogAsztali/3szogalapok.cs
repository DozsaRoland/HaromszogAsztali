using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromszogAsztali
{
   public class _3szogalapok
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }


        public _3szogalapok(double _a_, double _b_, double _c_)
        {
            a = _a_;
            b = _b_;
            c = _c_;
        }

        public bool Szerkeszt()
        {
            if (a + b > c && a + c > b && b + c > a) return true;
            throw new _3szogkivetel();
        }

        public double K()
        {
            return a + b + c;
        }

        public double T()
        {
            double s = K() / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public double Magassag()
        {
            double m = K();
            return m / 2;
        }
    }

    
}
