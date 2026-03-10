using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Logic
    {
        public static double GetSquareArea(double a) => a * a;

        public static double GetCircleArea(double r)
        {
            const double pi = 3.14;
            return r * r * pi;
        }
    }
}
