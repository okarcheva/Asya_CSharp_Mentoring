using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex1.Helpers;

namespace ex1.Exercises
{
    internal class Exercise1
    {
        public static void ReverseArray()
        {
            char[] arr = {'b', 'a', 't'};
            var arrReversed = arr.Reverse();
            foreach (int element in arrReversed)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }   
    }
}
