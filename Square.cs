using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kozyrev_PR2
{
    public class Square
    {
        public double CalculateRerimetrSquare(double a)
        {
            double P = a * 4;
            return P;
        }

        public double CalculateAreaSquare(double a)
        {
            double S = Math.Pow(a, 2);
            return S;
        }
    }
}
