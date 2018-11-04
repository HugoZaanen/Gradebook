using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //one-dimensional array of student grades
            int[] gradesArray = {87,68,94,100,83,78,85,91,76,87};

            var myGradebook = new GradeBook(
                "CS101 Introduction to C# Programming", gradesArray);
            myGradebook.ProcessGrades();
        }
    }
}
