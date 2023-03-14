using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {

        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Number of students is lower than 5");
            }

            var drop = (int)Math.Ceiling(Students.Count * 0.2);
            var grades = Students.OrderByDescending(a => a.AverageGrade).Select(a => a.AverageGrade).ToList();

            if (grades[drop - 1] <= averageGrade)
                return 'A';
            else if (grades[(drop * 2) - 1] <= averageGrade)
                return 'B';
            else if (grades[(drop * 3) - 1] <= averageGrade)
                return 'C';
            else if (grades[(drop * 4) - 1] <= averageGrade)
                return 'D';
            else
                return 'F';
            
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
                return;
            }
            else
            {
                base.CalculateStatistics();
            }
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
                return;
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }

            
        }

    }
}
