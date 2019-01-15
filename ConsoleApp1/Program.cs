using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 100);
            int count = 0;
            int guess = -1;
            Console.WriteLine("I'm thinking of a number between 0 and 100");
            while (guess != number)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess < number)
                    Console.WriteLine("too low");
                if (guess > number)
                    Console.WriteLine("too high");
                if (guess == number)
                    Console.WriteLine("correct value!");
                count++;
            }
            Console.WriteLine("Number of guesses made: " + count);




            Console.ReadKey();
        }
    }
}
