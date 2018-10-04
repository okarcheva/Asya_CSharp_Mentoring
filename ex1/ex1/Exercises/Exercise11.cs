using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Exercises
{
    class Exercise11
    {
        public static void FormatDataTime()
        {
            var now = DateTime.Now;
            var utcTime = DateTime.UtcNow;
            Console.WriteLine(now.ToString("ddd dd MMM, yyyy"));
            Console.WriteLine(now.ToString("dddd dd MMM, yyyy HH:mm:ss"));
            Console.WriteLine(now.ToString("mm'/'dd'/'yyyy"));
            Console.WriteLine(utcTime);
            Console.ReadLine();
        }
    }
}
