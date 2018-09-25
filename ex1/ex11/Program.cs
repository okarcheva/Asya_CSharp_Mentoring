using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine( now.ToString("F"));
            Console.WriteLine(now.ToString("D"));
            Console.WriteLine(now.ToString("M/d/yy"));
            Console.WriteLine(DateTime.UtcNow);
            Console.ReadLine();
        }
    }
}
