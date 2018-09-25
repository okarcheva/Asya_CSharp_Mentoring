using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elemens of array:");
            var numelem = int.Parse(Console.ReadLine());
            int[] array = new int [numelem];

            var max = 0;
            Random rn = new Random();

            for (int i=0; i<array.Length;i++)
            {
                array[i] = rn.Next(2,5);
                if (array[i] > max)
                    max = array[i];
                
                Console.WriteLine(array[i]+ " ; ");
            }

            Console.WriteLine($"max element: {max}");
            Console.ReadLine();
            

        }
    }
}
