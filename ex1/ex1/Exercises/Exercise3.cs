using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Exercises
{
    class Exercise3
    {
       public static void DigitVowel()
        {
            Console.WriteLine("Enter char:");
            char[] vowels = {'a', 'o', 'e', 'i', 'u'};
            var a = char.TryParse(Console.ReadLine(), out var result);

            if (Char.IsDigit(result))
            { Console.WriteLine("It's a number"); }
            else if (result.Equals('a')|| result.Equals('o')|| result.Equals('e')|| result.Equals('i')|| result.Equals('u'))

            { Console.WriteLine(" It's a lowercase vowel"); }
            else
            { Console.WriteLine("Other symbol"); }
            Console.ReadLine();
        }
    }
}

