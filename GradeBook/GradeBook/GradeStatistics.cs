using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{

    class GradeStatistics
    {
        public int Avarage;

        public void PrintStats()
        {
            Console.WriteLine(Avarage);
        }

        public GradeStatistics(int avarage)
        {
            Avarage = avarage;
        }
    }
}
