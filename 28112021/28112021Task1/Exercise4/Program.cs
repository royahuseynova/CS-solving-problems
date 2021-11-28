using System;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //50-1   (50 ve 1 daxil olmaqla) butun 3-e bolunen ededleri cap edin

            
                for (int d = 50; d >= 1; d--)
                {
                if (d % 3 == 0)
                {
                    Console.WriteLine(d);

                }
            }
        }
    }
}
