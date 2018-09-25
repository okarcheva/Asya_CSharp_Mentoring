using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements for array:");
            int numberofelements = int.Parse(Console.ReadLine());

            int[] array = new int [numberofelements];

            Random rand = new Random();

            for (int i=0; i<array.Length; i++)
            {
                array[i] = rand.Next(1, 5);
                Console.WriteLine(array[i] + " ; ");
            }
            var arrayReverse = array.Reverse();
            foreach (var element in arrayReverse)
            {
                Console.Write($"{element}  ");
            }
            Console.ReadLine();

        }
    }
}
