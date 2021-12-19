using System;

namespace Problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 reqemli eded verilib. Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir. Alinan cavabin 44 % tap.
            Step1:
            Console.Write("4 reqemli eded daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num>=1000 && num < 9999)
            {
                num *= 40000;
                num = (num * 1000000) + 44;
                num = num * 44 / 100;
                Console.WriteLine(num);
            }
            else
            {
             goto Step1; 
            }
        }
    }
}
