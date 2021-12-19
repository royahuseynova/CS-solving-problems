using System;

namespace Problem10
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /* 3 dene 4 reqemli eded verilib.  I ededin 1%-ni, II ededin 2% , III ededin 3 % tap. 
        Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7 % faizini gel*/

        Step1:

            Console.Write("4 reqemli a ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("4 reqemli b ededi daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("4 reqemli c ededi daxil edin: ");
            int c = Convert.ToInt32(Console.ReadLine());
            
            int d; // neticeleri bir birinden cixmaq ucun deyisen
            int e; // 3cu ededin 3%ni tapmaq ucun deyisken

            if (a>= 1000 && a < 9999 && b >= 1000 && b < 9999 && c >= 1000 && c< 9999)
            {
                a = a * 1 / 100;
                b = b * 2 / 100;
                e = c * 3 / 100;

                d = a - b - e;
                c = c * 7 / 100;
                d = d + c;

                Console.WriteLine (d);
            }
            else
            {
                goto Step1;
            }
        }
    }
}
