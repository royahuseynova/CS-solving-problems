using System;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirina da 8 reqemini artir. Example1: 3333= 73338

            Step1: 

            Console.Write("4 reqemli eded daxil edin: ");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num >=1000 && num<9999)
            {
                num = 70000 + num;
               
                num *= 10;

                num += 8;
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Yanlis reqem daxil etdiniz, yeniden sinayin!");
                goto Step1;
            }




            


        }
    }
}
