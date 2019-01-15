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
            
            int count = 0;
            int guess = -1;
            int start = 0;
            int stop = 0;
            Console.WriteLine("input lower bound");
            start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input upper bound");
            stop = Convert.ToInt32(Console.ReadLine());

            int number = rnd.Next(start, stop);

            Console.WriteLine("I'm thinking of a number between " + start + " and " + stop);
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
