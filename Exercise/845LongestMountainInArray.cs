using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _845LongestMountainInArray
    {
        public int LongestMountain(int[] A)
        {
            var len = 0;
            if (A.Length < 3) {
                return 0;
            }
            var preD = 0;
            var curLen = 1;
            for (var i = 0; i < A.Length; i++) {
                curLen++;
                if (i == A.Length - 1) {
                    if (preD < 0) {
                        if (curLen >= 3)
                        {
                            len = Math.Max(len, curLen);
                        }
                    }
                    break;
                }
                if (A[i + 1] - A[i] > 0) {
                    //curLen++;
                    if (preD <= 0) {
                        if (curLen >= 3) {
                            len = Math.Max(len, curLen);
                        }
                        curLen = 1;
                    }
                    preD = 1;
                }
                else if (A[i + 1] - A[i] == 0) {
                    //curLen++;
                    if (curLen >= 3)
                    {
                        len = Math.Max(len, curLen);
                    }
                    curLen = 1;
                    preD = 0;
                }
                else {
                    if (preD == 0)
                    {
                        curLen = 0;
                    }
                    preD = -1;
                }
            }
            
            return len;
        }
    }
}
