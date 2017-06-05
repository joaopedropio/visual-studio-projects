using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] output = Tribonacci(new double[] { 1, 1, 1 }, 8);
            return;
        }
        static double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0)
            {
                return new double[] { 0 };
            }
            else if (n <= 3)
            {
                double[] temp = new double[n];
                for(int i = 0; i < n; i++)
                {
                    temp[i] = signature[i];
                }
            }
            // hackonacci me
            // if n==0, then return an array of length 1, containing only a 0
            double fibanterior = 0, fib1 = 0, fib2 = 0;
            double[] output = new double[n];
            signature.CopyTo(output, 0);
            for (int i = 3; i < n; i++)
            {
                fibanterior = output[i - 3];
                fib1 = output[i - 2];
                fib2 = output[i - 1];
                output[i] = fibanterior + fib1 + fib2;
            }
            return output;
        }
    }
}
