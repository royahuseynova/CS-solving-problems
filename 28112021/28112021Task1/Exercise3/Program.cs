using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-50   (1 ve 50 daxil olmaqla) butun 2-ye bolunen ededleri cap edin

            
                for (int c = 1; c <= 50; c++)
                {
                if (c % 2 == 0)
                {
                    Console.WriteLine(c);

                }
            }
        }
    }
}
