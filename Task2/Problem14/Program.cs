using System;

namespace Problem14
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /* 6 dene 6 reqemli eded verilib. Evvel hamisini topla . Sonra I ve III ededi bir birine yapishdir ve bir eded al.  
I neticeden II neticeni cix. Alinan cavabin 10% tap. Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11% tap. */

        Step14:

            Console.Write("6 reqemli a ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("6 reqemli b ededi daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("6 reqemli c ededi daxil edin: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("6 reqemli d ededi daxil edin: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.Write("6 reqemli c ededi daxil edin: ");
            int f = Convert.ToInt32(Console.ReadLine());

            Console.Write("6 reqemli d ededi daxil edin: ");
            int g = Convert.ToInt32(Console.ReadLine());

            int sum, num1, result;

            if (a >= 100000 && a < 999999 && b >= 100000 && b < 999999 && c >= 100000 && c < 999999 && d >= 100000 && d < 999999 && f >= 100000 && f < 999999 && g >= 100000 && g < 999999)
            {
                sum = a + b + c + d + f + g;
                num1 = a * 1000000;
                num1 = num1 + c;
                Console.WriteLine(num1);
                result = sum - num1;
                result = result * 10 / 100;
                result = result + f + g;
                result = result * 11 / 100;
                Console.WriteLine(result);  

            }
            else
            {
                goto Step14;
            }
        }
    }
}
