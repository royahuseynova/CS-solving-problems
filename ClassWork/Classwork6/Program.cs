using System;

namespace Classwork6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] g = { 11, 23, 44, 55, 66 };
            int hasil = 6;
            int sum = ArrayComplex(g, ref hasil, out int min, out int max,3.14);
            
            Console.WriteLine($"Cem: {sum}; hasil: {hasil}");

            

        }
        public static int ArrayComplex(int[] b, ref int hasil, out int min,out int max,in double pi)
        {
            int cem = 0;
            hasil = 1;
           
            foreach (int i in b)
            {
                cem += i;
                hasil *= i;
            }
            min = b[0];
            max = b[0];
            for (int i = 0; i<b.Length; i++)
            {
                if (min > b[i])
                {
                    min = b[i];
                    
                }

                if (max < b[i])
                {
                    max = b[i];
                }
            }
            


           
            return cem;
        }
    }
}
