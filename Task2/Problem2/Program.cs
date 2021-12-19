using System;

namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir. example: 333= 333333;

            Step2:
            Console.Write(" 3 reqemli eded daxil edin: ");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = num1;

            if (num1>=100 && num1<999)
            {
                num1 *= 1000;
                num2 = num1 + num2;

                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine("Yanlis reqem daxil etdiniz, bir daha sinayin!");
                goto Step2;
            }
        }
    }
}
