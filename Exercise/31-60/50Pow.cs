using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _50Pow
    {
        public double MyPow(double x, int n)
        {
            uint power = (uint)n; 
            if (n < 0)
            {
                x = 1 / x;
                power = (uint) -n;
            }
            if (n == 0)
            {
                return 1;
            }
            if (x == 1)
            {
                return 1;
            }
            var res= power%2 == 0? MyPow(x*x, power/2) : x*MyPow(x*x, power/2);
            return res;
        }

        public double MyPow(double x, uint n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n % 2 == 0 ? MyPow(x * x, n / 2) : x * MyPow(x * x, n / 2);
        }
    }
}
