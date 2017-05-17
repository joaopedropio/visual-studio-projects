using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: "); 
            string nome = Console.ReadLine();
            Console.WriteLine("Ola, " + nome + ". Quantas horas dormiu hoje?");
            int horas = int.Parse(Console.ReadLine());
            if (horas < 8)
                Console.WriteLine("Feeling sleepy\n");
            else
                Console.WriteLine("Very well\n");
            Console.ReadLine();
        }

    }
}
