using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Exercises
{
    class Exercise9
    {
        public static void MaxElementOfArray()
        {
            Console.WriteLine("Enter number of elemens of array:");
            var numelem = int.Parse(Console.ReadLine());
            var array = new int[numelem];

            var max = 0;
            var rn = new Random();
            Console.WriteLine("Array:");

            for (int i =0; i<array.Length; i++)
            {
                array[i] = rn.Next(2, 20);
                Console.WriteLine(array[i]);
            }

            foreach (var element in array)
            {
                if (element > max)
                    max = element;
            }
            Console.WriteLine($"Max element: {max}");
            Console.ReadLine();
        }
    }
}
