using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook livro = new GradeBook();

            Console.WriteLine("Adicione uma nota: ");
            int grade = int.Parse(Console.ReadLine());
            livro.AddGrade(grade);
            GradeStatistics stats = livro.CalcStatistics();
            stats.PrintStats();
            Console.ReadLine();
        }
    }
}
