using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Exercises
{
    class Exercise12
    {
        public static void DataTimeAddDays()
        {
            var dt = DateTime.Now;
            Console.WriteLine(dt.AddDays(40));
            Console.WriteLine(dt.AddDays(40).ToString("dddd"));
            Console.ReadLine();
        }
    }
}
