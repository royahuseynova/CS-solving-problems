using System;

namespace Problem15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
    3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
    Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
    Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
    Sonra alinan cavabin ustune gel 6 reqemli ededi.
    Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
    Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
    Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel */


            Console.Write(" 3 reqemli a ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write(" 3 reqemli b ededi daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write(" 4 reqemli c ededi daxil edin: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write(" 4 reqemli d ededi daxil edin: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.Write("5 reqemli e ededi daxil edin: ");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.Write("5 reqemli f ededi daxil edin: ");
            int f = Convert.ToInt32(Console.ReadLine());

            Console.Write("6 reqemli g ededi daxil edin: ");
            int g = Convert.ToInt32(Console.ReadLine());

            int sum1, multiply1, multiply2, sum2, sum3, result1, result2, finalResult;

            if (a >= 100 && a <999 && b >= 100 && b < 999 && c >= 1000 && c <9999 && d >= 1000 && d < 9999 && e >= 10000 && e < 99999 && f >= 10000 && f < 99999 && g >= 100000 && g < 999999)
            {
                sum1 = a + b;
                multiply1 = c * d;
                sum1 = sum1 + multiply1;
                sum1 = sum1 * 10;
                sum1 = sum1 + 7;
                sum2 = e + f;
                sum3 = sum1 + sum2;
                multiply2 = a * b;
                multiply2 = multiply2 * 10;
                result1 = multiply2 + 1;

                result2 = result1 + g;
                result2 = result2 - (a + b + c + d);
                result2 = result2 * 18 / 100;
                result2 = result2 * 3 / 100;
                result2 = result2 * 1 / 100;
                finalResult = result2 + sum2;
                Console.WriteLine(finalResult);
            }
        }
    }
}
