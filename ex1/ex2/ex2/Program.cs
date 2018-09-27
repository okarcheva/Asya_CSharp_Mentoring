using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex2;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var rnd = new Random();
            //var y = rnd.Next(-5, 6);

            var arr = Enumerable.Range(-5, 11);

            //var arr = new int[]{ -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };

            foreach (var y in arr)
            {
                Console.WriteLine(y);
                //int y = element;
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"y: {y}");
                Console.WriteLine($"x = y * y + 2 * y + 1 = {x}");
            }

            Console.ReadLine();

        }
    }
}
