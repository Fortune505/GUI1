using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Logic
    {
        public static double GetSKv(double a) => a * a;

        public static double GetSKr(double r)
        {
            const double pi = 3.14;
            return r * r * pi;
        }
    }
}
