using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _813LargestSumOfAverages
    {
        public double LargestSumOfAverages(int[] A, int K)
        {
            if (K == 1) {
                return Sum(A, 0, A.Length - 1)/A.Length;
            }
            if (K == A.Length) {
                return Sum(A, 0 , A.Length - 1);
            }

            var D = new double[A.Length, K];
            double max = 0.0;

            for (var i = A.Length - K; i >= 0; i--) {
                double sum = Sum(A, 0, i)/(i+1);
                sum += LargestSumOfAverages(A, i+1, K-1, D);
                if (max < sum) {
                    max = sum;
                }
            }

            return max;
        }

        private double LargestSumOfAverages(int[] A, int start, int K, double[,] D)
        {
            if (D[start, K] != 0) {
                return D[start, K];
            }
            if (K == 1) {
                D[start, K] = Sum(A, start, A.Length - 1) / (A.Length - start);
                return D[start, K];
            }
            if (K == A.Length - start) {
                D[start, K] = Sum(A, start, A.Length - 1);
                return D[start, K];
            }

            double max = 0.0;
            for (var i = A.Length - K; i >= start; i--) {
                double sum = Sum(A, start, i)/(i - start + 1);
                sum += LargestSumOfAverages(A, i+1, K-1, D);
                if (max < sum) {
                    max = sum;
                }
            }
            D[start, K] = max;
            return D[start, K];
        }

        private double Sum(int[] A, int start, int end) {
            long sum = 0;
            for (var i = start; i <= end; i++) {
                sum += A[i];
            }
            return sum;
        }
    }
}
