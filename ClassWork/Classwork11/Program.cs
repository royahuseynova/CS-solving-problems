using System;

namespace Classwork11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32("123");
            int b = int.Parse("123"); // ancaq stringi cevire bilir
           
            byte c = byte.Parse("11");

            int eded;
            bool t = int.TryParse("12",out eded); // ancaq stringden ishleyir

            if (t == true)
            {
                Console.WriteLine(eded);
            }
            else
            {
                Console.WriteLine("convert olmadi");
            }

            
        }
        public static int TRYP(string caption)
        {
        step:
            Console.Write("eded daxil et");
            string input = Console.ReadLine();
            bool scs = int.TryParse(input, out int result);
            if (scs == true)
            {
                return result;
            }
            else
            {
                goto step;
            }
        }
    }
}
