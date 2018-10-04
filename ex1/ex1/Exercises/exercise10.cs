using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Exercises
{
    class Exercise10
    {
        public static void ReverseArray()
        {
            Console.WriteLine("Enter number of elements for array:");
            var numberofelements = int.Parse(Console.ReadLine());

            int[] array = new int[numberofelements];

            Random rand = new Random();

            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 10);
                Console.WriteLine(array[i]);
            }
            var arrayReverse = array.Reverse();
            Console.WriteLine("Reversed array:");
            foreach (var element in arrayReverse)
            {
                Console.Write($"{element} ");
            }
            Console.ReadLine();


        }

        private static object Reverce(int[] array)
        {
            throw new NotImplementedException();
        }
    }
}
