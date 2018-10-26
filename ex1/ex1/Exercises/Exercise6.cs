using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Exercises
{
    class Exercise6
    {
        public static void SubjectsMarks ()
        {
            const int m = 65;
            const int p = 55;
            const int c = 50;
            const int cmp = 180;
            const int mp = 140;
            const int mc = 140;

            Console.WriteLine("Enter Maths balls:");
            var maths = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Phy balls:");
            var phy = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Chem balls:");
            var chem = int.Parse(Console.ReadLine());

            if ((maths >= m && phy >= p && chem >= c && chem + maths + phy >= cmp) ||
                (maths + phy >= mp && maths + chem >= mc))
            {
                Console.WriteLine($"chem + maths + phy={chem + maths + phy}");
                Console.WriteLine($"maths + phy={maths + phy}");
                Console.WriteLine($"maths + chem={maths + chem}");
                Console.WriteLine("You are good!");
            }

            else
            {
                Console.WriteLine("You are Not good!");
            }
            Console.ReadLine();

        }
    }
}
