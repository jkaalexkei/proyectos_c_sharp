using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicasVarias
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            int gradeA = 4;
            int gradeB = 3;

            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;

            Console.WriteLine($"{course1Name} {course1Grade}");
            Console.WriteLine($"{course2Name} {course2Grade}");
            Console.WriteLine($"{course3Name} {course3Grade}");
            Console.WriteLine($"{course4Name} {course4Grade}");
            Console.WriteLine($"{course5Name} {course5Grade}");

            Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
            Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
            Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
            Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
            Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");

            int totalCreditHours = 0;

            totalCreditHours += course1Credit;
            totalCreditHours += course2Credit;
            totalCreditHours += course3Credit;
            totalCreditHours += course4Credit;
            totalCreditHours += course5Credit;

            totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

            int totalGradePoints = 0;

            totalGradePoints += course1Credit * course1Grade;

            totalGradePoints += course2Credit * course2Grade;
            totalGradePoints += course3Credit * course3Grade;
            totalGradePoints += course4Credit * course4Grade;
            totalGradePoints += course5Credit * course5Grade;

            //decimal gradePointAverage = totalGradePoints / totalCreditHours;
            decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

            int leadingDigit = (int)gradePointAverage;
            
            int firstDigit = (int)(2.994573 * 10) % 10;
            int firstDigit = 29 % 10;
            int firstDigit = 9;
            Console.WriteLine($"Final GPA: {gradePointAverage}");

        }
    }
}
