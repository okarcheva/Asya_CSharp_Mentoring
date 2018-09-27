using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
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
