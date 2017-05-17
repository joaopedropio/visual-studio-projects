using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class GradeBook
    {
        int grades;

        public void AddGrade(int grade)
        {
            grades = grade;
        }

        public GradeStatistics CalcStatistics()
        {
            GradeStatistics stats = new GradeStatistics(grades);
            return stats;
        }
    }
}
