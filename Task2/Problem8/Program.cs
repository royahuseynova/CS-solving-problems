using System;

namespace Problem8
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /* 2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.
I ededin 4%-ni tap. 
Sonra II ededin 9% ni tap. 
Sonra Cavalari toplayib 10 %ni tap. */


       Step1:
            Console.Write("4 reqemli a ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("7 reqemli b ededi daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = 0;
            if (a>=1000 && a <9999)
            {
              a = a * 4 / 100;

            }
            else
            {
                goto Step1;
            }

            if (b >= 1000000 && b< 9999999)
            {
                b = b * 9 / 100;
            }
            else
            {
                goto Step1;
            }

            c = a + b;
            c = c * 10 / 100;

            Console.WriteLine(c);
        }
    }
}
