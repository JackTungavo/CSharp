using System;

namespace CSharp.IfFizzBuzz
{
    class FizzBuzz
    {
        public static string Play(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz.Play(1));  
            // should print 1
            Console.WriteLine(FizzBuzz.Play(3)); 
            // should print Fizz
            Console.WriteLine(FizzBuzz.Play(5));   
            // should print Buzz
            Console.WriteLine(FizzBuzz.Play(15));  
            // should print FizzBuzz
        }
    }
}
