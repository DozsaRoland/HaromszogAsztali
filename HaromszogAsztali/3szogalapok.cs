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


        public _3szogalapok(double _a, double _b, double _c)
        {
            a = _a;
            b = _b;
            c = _c;
        }

        public bool szerkeszt()
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
    }

    
}
