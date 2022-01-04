using System;

namespace Classwork04Jan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[0];
           int sum = 0;
            Console.WriteLine("eded daxil etmek isteyirsiniz? he ucun enter duymesini sixin");
          while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Write("eded:");
                int eded = Convert.ToInt32(Console.ReadLine());
                // sum = sum + eded;
                Array.Resize(ref arr, arr.Length+1);
                arr[arr.Length - 1] = eded;

               // Console.WriteLine(sum);

                Console.WriteLine("enteri klikledin");
                Console.WriteLine("eded daxil etmek isteyirsiniz? he ucun enter duymesini sixin");
               
            }

            Console.WriteLine( "__________"); 
           // Console.WriteLine(sum);

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
