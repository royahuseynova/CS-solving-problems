using System;

namespace Problem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // 4 reqemli eded verilib. Bu ededin evvel 20%-ni ,  sonra ise cavabin 10% tap.  Alinan  cavabin kvadratini tap

        Step1:

            Console.WriteLine("4 reqemli eded daxil edin: ");
            double num = Convert.ToDouble(Console.ReadLine());

            if (num >= 1000 && num <9999)
            {
                num = num * 20 / 100;
                num = num * 10 / 100;
                num = Math.Pow( num, 2);
                Console.WriteLine(num);

            }
            else
            {
                goto Step1;
            }
        }
    }
}
