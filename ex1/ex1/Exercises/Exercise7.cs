using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Exercises
{
    internal class Exercise7
    {
        internal static void GradeEquivalentDescription ()
        {
            Console.WriteLine("Enter a grade:");
            var grade = Console.ReadLine().ToLower();

            switch (grade)
            {
                case "e":
                    Console.WriteLine("Excellent");
                    break;
                case "v":
                    Console.WriteLine("Very Good");
                    break;
                case "g":
                    Console.WriteLine("Good");
                    break;
                case "a":
                    Console.WriteLine("Average");
                    break;
                case "f":
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("!!!");
                    break;
            }
            Console.ReadLine();

        }
    }
}
