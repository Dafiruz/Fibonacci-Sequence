using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, number = 0, previous = 1, second_previous = 1;

            Console.WriteLine("Welcome to the Fibonacci Sequence!");
            Console.WriteLine();
            Console.WriteLine("Would you like to see the Fibonacci Sequence until what number?");
            int.TryParse(Console.ReadLine(), out max);
            Console.WriteLine("---------");

            Console.WriteLine(number);
            Console.WriteLine(previous);
            Console.WriteLine(second_previous);
            do
            {
                number = previous + second_previous;
                second_previous = previous;
                previous = number;
                Console.WriteLine(number);
            } while (number < max);

            Console.WriteLine("---------");
            Console.WriteLine();
            Console.WriteLine("Press Any Key to Exit!");
            Console.ReadKey();
        }
    }
}
