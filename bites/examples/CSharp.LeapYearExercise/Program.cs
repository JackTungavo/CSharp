using System;

namespace CSharp.LeapYearExercise
{
    class LeapYear
    {
        public static bool IsLeapYear(int year)
        {
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LeapYear.IsLeapYear(2000)); // => true
            Console.WriteLine(LeapYear.IsLeapYear(1970)); // => false
            Console.WriteLine(LeapYear.IsLeapYear(1900)); // => false
            Console.WriteLine(LeapYear.IsLeapYear(1988)); // => true
            Console.WriteLine(LeapYear.IsLeapYear(1500)); // => false

        }

    }

}