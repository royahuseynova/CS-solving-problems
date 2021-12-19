using System;

namespace Problem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // 2 dene 5 reqemli eded verilib. Bu ededleri toplayib. Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap


        Step1:

            Console.Write("5 reqemli a ededini daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("5 reqemli b ededini daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            double c;
            string d;

            if ( a >= 10000 && a<99999 && b>= 10000 && b < 99999)
            {
                c = (a + b);
               d = Convert.ToString(c);
                d = 5 + d;
                c = Convert.ToDouble(d);
                c = c + 0.5;
                c = c * 5 / 100;
                Console.WriteLine(c); 
            }
            else
            {
                goto Step1; 
            }
        }
    }
}
