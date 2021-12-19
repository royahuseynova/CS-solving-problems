using System;

namespace Problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;
            Step1:

            Console.Write(" 3 reqemli eded daxil edin: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            if (num4>=100 && num4<999)
            {
                num4 = (num4 * 10) + 7;
                Console.WriteLine(num4);

                num4 = num4 * 7 / 100;
                Console.WriteLine(num4);
            }
            else
            {
                goto Step1;
            }
        }
    }
}
