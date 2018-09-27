using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter char:");
            var a = char.Parse(Console.ReadLine());
            //char c = Convert.ToChar(Console.ReadLine());

            //var vowels = new char['a', 'o', 'e', 'i', 'u', 'A', 'O', 'U', 'E', 'I'];            

            var vowels1 = "aoeiu";
            vowels1.Contains(a);





            if (Char.IsDigit(a))
            { Console.WriteLine(a + " It's a number."); }
            if (a.Equals('a') ||)
            { Console.WriteLine(a + " It's a lowercase vowel."); }
            else
            { Console.WriteLine(a + " It's NOT a lowercase vowel."); }
            Console.ReadLine();
        }
    }
}

