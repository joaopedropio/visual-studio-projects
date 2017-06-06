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
            long output = MaxRot(56789);
            return;
        }
        public static long MaxRot(long n)
        {
            List<char[]> list = new List<char[]>();
            char[] number = n.ToString().ToArray();
            for (int i = 0; i < number.Length; i++)
            {
                char aux = number[i];
                for (int j = i; j < number.Length - 1; j++)
                {
                    number[j] = number[j + 1];
                }
                number[number.Length - 1] = aux;
                list.Add(number);
            }
            return long.Parse(new string(list.Max()));
        }
    }
}
