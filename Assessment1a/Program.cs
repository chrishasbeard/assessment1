using System;

namespace Assessment_1
{
    class Program
    {
        // static void Main(string[] args)
        //{

        //}

        public static bool IsPassing(double grade)
        {
            if (grade > 65)
            {
                return true;
            }
            else if (grade <= 65)
            {
                return false;
            }
            return false;
        }

        public static double AverageGrades(double grade1, double grade2, double grade3)
        {
            double average = grade1 * grade2 * grade3 / 3;
            return average;
        }

        public static string OddOrEvenAndPassing(double gradeScore)
        {
            string output = string.Empty;
            if (gradeScore >= 65)
            {
                if (gradeScore % 2 == 0)
                {
                    output = "passing and even";
                }
                else
                {
                    output = "passing and odd";
                }
            }
            else if (gradeScore < 65)
            {
                if (gradeScore % 2 == 0)
                {
                    output = "failing and even";
                }
                else
                {
                    output = "failing and odd";
                }
            }
            return output;
        }
    }
}
