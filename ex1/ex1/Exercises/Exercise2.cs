using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Exercises
{
    public class Exercise2
    {
        public static void CulculateFormula()
        { var array = Enumerable. Range(-5, 11);

            foreach (int y in array)
            {
                Console.WriteLine($"y= {y}");

                var x = y * y + 2 * y + 1;
                Console.WriteLine($"x = y2 + 2y + 1={x}");
            }

            Console.ReadLine();
        }
    }
}
  

