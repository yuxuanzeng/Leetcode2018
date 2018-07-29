using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _762PrimeNumber
    {
        public int CountPrimeSetBits(int L, int R)
        {
            var res = 0;
            for (var i = L; i <= R; i++) {
                if (HasPrimeSetBits(i)) {
                    res++;
                }
            }
            return res;
        }
        public List<int> primes = new List<int>(){ 2,3,5,7,11,13,17,19};
        public bool HasPrimeSetBits(int i) {
            var bits = 0;
            while (i != 0) {
                if ((i & 1) == 1) {
                    bits++;
                }
                i >>= 1;
            }
            if (primes.Contains(bits)) {
                return true;
            }
            return false;
        }
    }
}
