using System;

namespace Classwork7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] h = { 11, 23, 1, 2, 3 };

            int a = ReadInteger("a: ");

            int b = a * a;
            Console.WriteLine(b);

          
            int x = ReadInteger("x: ");

            int y = x * x;
            Console.WriteLine(y);

            string name = ReadString("Adinizi daxil edin: ");
            string surname = ReadString("Soyadinizi daxil edin: ");

            int arr = ReadInteger("nece meyve isteyirsiniz? ");
            string[] fruits = new string[arr];
            for (int i = 0; i < fruits.Length; i++)
            {
                string fruit = ReadString($"fruit {i + 1}: ");
                fruits[i] = fruit;
            }
            Console.WriteLine("List of fruits");
            foreach(var item in fruits)
            {
                Console.WriteLine(item);
            }
        }

        static int ReadInteger(string caption)
        {
            int a;
            readAgain:
           try
            {
                Console.Write(caption);
                 a = Convert.ToInt32(Console.ReadLine());
                return a;
            }
            catch (Exception)
            {
                Console.WriteLine("yemiden cehd edin");
                goto readAgain;
            }
            
        }

        static string ReadString(string caption)
        {
           
            readAgain1:
            try
            {
                Console.Write(caption);
                string b = Console.ReadLine();
                if (b.Length <= 1)
                {
                    goto readAgain1;
                }
                return b;
            }
            catch (Exception)
            {
                Console.Write("yeniden cehd edin");
                goto readAgain1;
            }
        }

        

    }
}
