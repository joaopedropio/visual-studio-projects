using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {

        public static void Main()
        {
            int a = 3;
            int b = 3;
            Console.WriteLine((a == b) ? "true" : "false");
            Console.WriteLine((object)a == (object)b ? "true" : "false");
            Console.WriteLine((IComparable<int>)a == (IComparable<int>)b ? "true" : "false");
            Console.WriteLine(string.Equals("apple piE", "apple pie",StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine(4.0000001f == 4.0000000f);
            int basic= int.Parse(Console.ReadLine());
            Console.WriteLine(basic);
            return;
        }
    }
}