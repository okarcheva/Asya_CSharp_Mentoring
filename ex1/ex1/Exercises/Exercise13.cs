using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Exercises
{
    class Exercise13
    {
        public static void DateCompare()
        {
            var dt1 = DateTime.Parse("8/1/2016 12:00:00");
            var dt2 = DateTime.Parse("8/1/2016 16:00:00"); 

            if (dt1.Date > dt2.Date)
            {
                Console.WriteLine(dt1.ToString("dd'/'MM'/'yyyy HH:mm:ss") + "is leter than" + dt2.ToString("dd'/'MM'/'yyyy HH:mm:ss"));
            }
            else
            {
                Console.WriteLine(dt1.ToString("dd'/'MM'/'yyyy HH:mm:ss") + " is earlier than  " + dt2.ToString("dd'/'MM'/'yyyy HH:mm:ss"));
            }
            Console.ReadLine();
        }
       

    }
}
