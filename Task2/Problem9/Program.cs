using System;

namespace Problem9
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // 3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap.

        Step1:

            Console.Write("6 reqemli a ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("6 reqemli b ededini daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("6 reqemli c ededi daxil edin: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a >= 100000 && a <999999)
            {
                a = a * 10 / 100;
            }

            else
            {
                goto Step1;
            }


        }
    }
}
