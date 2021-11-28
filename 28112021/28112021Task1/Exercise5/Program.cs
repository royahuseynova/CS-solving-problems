using System;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //50-1   (50 ve 1 daxil olmaqla) butun 3-e ve eyni zamanda 7-ye bolunen ededleri cap edin   (hem 3-e hem 7ye bolune bilen ededler)


            
                for (int e = 50; e >= 1; e--)
                {
                if (e % 3 == 0 && e % 7 == 0)
                {
                    Console.WriteLine(e);
                }
            }

        }
    }
}
