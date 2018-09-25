using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Maths balls:");
            var maths = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Phy balls:");
            var phy = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Chem balls:");
            var chem = int.Parse(Console.ReadLine());

            if ((maths >= 65 && phy >= 55 && chem >= 50 && chem + maths + phy >= 180) ||
                (maths + phy >= 140 && maths + chem >= 140))
            {
                Console.WriteLine($"chem + maths + phy={chem + maths + phy}");
                Console.WriteLine($"maths + phy={maths + phy}");
                Console.WriteLine($"maths + chem={maths + chem}");
                Console.WriteLine("You are good!");
            }

            else
            {
                Console.WriteLine("You are Not good!");
                Console.WriteLine($"chem + maths + phy={chem + maths + phy}");
                Console.WriteLine($"maths + phy={maths + phy}");
                Console.WriteLine($"maths + chem={maths + chem}");
            }
            Console.ReadLine();

        }
    }
}
