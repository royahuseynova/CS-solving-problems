using System;

namespace Problem13
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /* 5 dene eded verilib. Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir. 5 reqemli ededlerin 5% tap ,neticeleri vur bir birine. 
Sonra 3 reqemli ededlerin 3% tap ,neticeleri topla. Sonra yekunda alinan iki cavalarin her birinin 10%-ni tapib topla */

        Step1:
            Console.Write("5 reqemli a ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("5 reqemli b ededi daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("5 reqemli c ededi daxil edin: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("3 reqemli d ededi daxil edin: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.Write("3 reqemli e ededi daxil edin: ");
            int e = Convert.ToInt32(Console.ReadLine());

            if ( a >= 10000 && a <99999 && b >= 10000 && b < 99999 && c >= 10000 && c < 99999 && d >= 100 && a < 999 && e >= 100 && e < 999)
            {
                a = a * 5 / 100;
                b = b * 5 / 100;
                c = c * 5 / 100;
                a = a * b * c;

                d = d * 3 / 100;
                e = e * 3 / 100;
                d = d + e;

                a = a * 10 / 100;
                e = e * 10 / 100;
                a = a + e;

                Console.WriteLine(a);
            }
            else
            {
                goto Step1;
            }
        }
    }
}
