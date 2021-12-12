using System;

namespace Classwork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region sizeOfDataTypes
            int a = 5;
            long b = 7;
            Console.WriteLine(sizeof(int));
            var sizeOfLong = sizeof(long);
            Console.WriteLine(sizeOfLong);

            #endregion

            #region introductionToIf
            int d = -5;

            if (d > 0)
            {
                Console.WriteLine("musbetdir");

            }
            else if (d < 0)
            {
                Console.WriteLine("menfidir");
            }
            else
            {
                Console.WriteLine("0dir");
            }
            #endregion

            #region ifSpeedProblem
            int firstLimit = 60;

            int speed = 80;
            int diff = speed - (firstLimit + 10);

            /* if (diff < 20)
            {
               if (diff > 0)
                {
                    Console.WriteLine("10 man cerimelendiniz");
                }
            }
            else if (diff < 40)
            {
                if (diff >= 20)
                {
                    Console.WriteLine("20 man cerimelendiniz");
                }
            } */

            if (diff < 20 && diff > 0)
            {
                Console.WriteLine("10 man cerimelendiniz");

            } 

            else if (diff < 40 && diff >= 20)
            {
                Console.WriteLine("20 man cerimelendiniz");
            }

            else if (diff < 60 && diff >= 40)
            {
                Console.WriteLine(" 50 man cerimelendiniz");
            }
            else if (diff > 0)
            {
                Console.WriteLine("qaydalara uygun deyil");
            }
            else
            {
                Console.WriteLine(" duzgun ");
            }
            #endregion


            #region introductionToForLoop
            int i;

            for (i = 0; i <5; i++)
            {

                Console.WriteLine(i);

            }
            Console.WriteLine(i + "Test");

            #endregion
        }
    }
}
