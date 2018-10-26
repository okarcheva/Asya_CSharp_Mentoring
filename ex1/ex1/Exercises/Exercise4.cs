using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Exercise4
    {
        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter numer");
            var number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
            
            Console.ReadLine();
        }
    }
}
