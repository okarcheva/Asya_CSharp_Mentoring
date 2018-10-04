using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

            Exercise7.GradeEquivalentDescription();
        }

        internal static void PlayWithParams(int count = 0, int[] parameters = null)
        {
            var sum = parameters.Sum();
            Console.WriteLine(sum);
        }
    }
}
