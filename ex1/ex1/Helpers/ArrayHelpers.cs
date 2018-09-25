using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Helpers
{
    static class ArrayHelpers
    {
        public static void ReverseArray()
        {
            char[] arr = { 'b', 'a', 't' };
            var arrReversed = arr.Reverse();
            foreach (int element in arrReversed)
            {
                Console.WriteLine(element);
            }
        }
    }
}
