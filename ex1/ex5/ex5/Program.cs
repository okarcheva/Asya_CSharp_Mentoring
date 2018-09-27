using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number:");
            int one = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number:");
            int sec = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the 3rd number:");
            int th = int.Parse(Console.ReadLine());

            if (one > sec && one > th)
                Console.WriteLine("The 1st Number is the greatest among three");
            if (sec > one && sec > th)
                Console.WriteLine("The 2nd Number is the greatest among three");
            if (th > sec && th > one)
                Console.WriteLine("The 3rd Number is the greatest among three");
            Console.ReadLine();

        }
    }
}

