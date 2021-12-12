using System;

namespace _30Nov2021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topla(a,b) kimi
Ferq(a,b)
Hasil(a,b)
Nisbet(a,b) 

methodlarini hazirladiqdan sonra 

Istifadecinin daxil etdiyi (Console.ReadLine) a ve b ededlerine gore bu methodlari cagirib istifade edib
return deyeri ekrana cap edin */
            
            Console.WriteLine(" a reqemini daxil edin: ");
           int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b reqemini daxil edin: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
           

           
            Console.WriteLine (Topla(num1, num2));
         Console.WriteLine (Ferq(num1, num2));
         Console.WriteLine (Hasil(num1, num2));
          Console.WriteLine(Nisbet(num1, num2));



        }
        static int Topla(int a, int b)
        {
            return a + b;
        }

        static int Ferq(int a, int b)
        {
            return a - b;
        }

        static int Hasil(int a, int b)
        {
            return a * b;
        }

        static double Nisbet(int a, int b)
        {
            return a / b;
        }
    }
}
