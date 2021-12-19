using System;

namespace Problem12
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /* 4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin 15 faizini tap ve topla. 
        Sonra yekunda alinanlar iki cavabi vur biri birine. Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap. */


        Step1:

            Console.Write("6 reqemli a ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("6 reqemli b ededi daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("6 reqemli c ededi daxil edin: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("6 reqemli d ededi daxil edin: ");
            int d = Convert.ToInt32(Console.ReadLine());

            int e, f, g, h;

            if (a >= 100000 && a < 999999 && b >= 100000 && b < 999999 && c >= 100000 && c < 999999 && d >= 100000 && d < 999999)
            {
                e = a * 10 / 100;
                f = b * 10 / 100;
                g = c * 10 / 100;
                h = d * 10 / 100;
                e = e + f + g + h;

                a = a * 15 / 100;
                b = b * 15 / 100;
                c = c * 15 / 100;
                d = d * 15 / 100;
                a = a + b + c + d;

                e = e * a;
                e = e * 10 / 100;
                e = e * 11 / 100;

                Console.WriteLine(e);
            }
            else
            {
                goto Step1;
            }
        }
    }
}
