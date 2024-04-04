using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kozyrev_PR2
{
    public class Circle
    {
        public double CalculateRerimetrCircle(double R)
        {
            double C = 2 * Math.PI * R;
            return C;
        }

        public double CalculateAreaCircle(double R)
        {
            double A = Math.PI * Math.Pow(R, 2);
            return A;
        }
    }
}
