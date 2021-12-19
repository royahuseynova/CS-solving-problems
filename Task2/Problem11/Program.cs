using System;

namespace Problem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /*
         4 dene 5 reqemli eded verilib. Her I ededin ustune III ededi gel . II ededin usutune IV eeddi gel. 
Sonra cavablari vur birbirine. Alinan neticeden III ededin 3%-ni cix.
         */

        Step1:

            Console.Write("5 reqemli a ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("5 reqemli b ededi daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("5 reqemli c ededi daxil edin: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("5 reqemli d ededi daxil edin: ");
            int d = Convert.ToInt32(Console.ReadLine());

            int e;

            if (a >= 10000 && a<99999 && b >= 10000 && b < 99999 && c >= 10000 && c < 99999 && d >= 10000 && d < 99999)
            {
                a = a + c;
                b = b + d;
                e = a + b;
                c = c * 3 / 100;
                e = e - c;

                Console.WriteLine(e);
            }
            else
            {
                goto Step1;
            }
        }
    }
}
