using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Exercises
{
    class Exercise14
    {
        public static void Hours()
        {
            var dt1 = DateTime.Parse("01/01/2000 00:00:00");
            var dt2 = DateTime.Now;

            Console.WriteLine($"Hours:{dt2.Subtract(dt1).TotalHours}");

            Console.Read();
        }
    }
}
