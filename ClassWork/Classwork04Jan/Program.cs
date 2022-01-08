using System;

namespace Classwork04Jan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] arr = new Book[0];
           
            Console.WriteLine("kitab daxil etmek isteyirsiniz? he ucun enter duymesini sixin");
          while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Book book = new Book();

                Console.Write("book name:");
                book.Name = Console.ReadLine();
                Console.Write("Author name: ");
                book.Author = Console.ReadLine();
                
                
                
                Array.Resize(ref arr, arr.Length+1);
                arr[arr.Length - 1] = book;

               // Console.WriteLine(sum);

                Console.WriteLine("enteri klikledin");
                Console.WriteLine("eded daxil etmek isteyirsiniz? he ucun enter duymesini sixin");
               
            }

            Console.WriteLine( "__________"); 
           // Console.WriteLine(sum);

            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
