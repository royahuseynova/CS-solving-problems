using System;

namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //  5 reqemli eded verilib. Bu ededin evvel  18 % sonra ise 3 % tap

        Step1:
            Console.Write("5 reqemli eded daxil edin: ");

            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num3 >= 10000 && num3 < 99999)
            {
                num3 = num3 * 18 / 100;
                num3 = num3 * 3 / 100;
                Console.WriteLine(num3);
            }
            else
            {
                goto Step1; 
            }
        }
    }
}
