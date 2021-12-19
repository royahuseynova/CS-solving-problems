using System;

namespace ClassWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            #region firstExample
            
          
            int[] b = { 1, 2, 3, 4, 5, 6 }; //istediyimiz kimi manupile ede bilmerik

            for (int i = 0; i <= b.Length-1; i++) 
            {
                b[i] = b[i] * b[i];
                // b[i] = (int) Math.Pow(b[i],2); //double verdiyi ucun inte cast eleyirik;

            }
        for (int i  = 0; i<= b.Length-1; i++)
            {
                Console.WriteLine(b[i]);
            }
            #endregion



            #region secondExample
            // Console.WriteLine("a: ");
            // int[] a = new int[Console.ReadLine()];

            int[] a = new int[3];
            a [0]= 4;
            a[1] = 11;
            a[2] = 5;

            /* for (int i = a.Length-1; i >=0; i--)
            {
                a[i] = (int)Math.Pow(a[i], 2);
               
            }
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            } */

            /* foreach ( int i in a)
            {
                Console.WriteLine(i);

            } */

             for (int i = 0; i <=a.Length-1; i++)
            {
                // Console.WriteLine(i);
                // int item = a[i];
                // Console.WriteLine(item);
                // Console.WriteLine($"{i} : {a[i]}");
            }
             


            #endregion

            #region thirdExample
            int result;

            for (int j = 1; j <= 10; j++)
            {
                for (int i = 2; i < 10; i++)
                {
                
                    result = i * j;
                    Console.Write($"{i.ToString().PadLeft(2)} * {j.ToString().PadLeft(2)} = {result.ToString().PadLeft(2)})\t");

                }
            }

            #endregion

            #region fourthExample


            object city1 = new
            {
                name = "Baku",
                temp = 8.5,


            };
            object city2 = new

            {
                name = "Ganja",
                temp = 9,

            };

            Console.WriteLine(city1);
            var city3 = new City();

            city3.name = "Sheki";
            city3.temprature = 5.5;
            Console.WriteLine(city3.name);


            #endregion

            #region fifthExample 

            Console.WriteLine("Start");
            Person.WakeUp();
            Person.Washing();
            Person.Breakfast();
            Person.Washing();
            string n = "";
            int x = new int();
            Person p = new Person();
            p.name = "Aynur";
            p.surname = "Abbasova";
            p.age = 40;

            Console.WriteLine("End");
            Person ry = new Person();
            ry.name = "Roya";
            ry.surname = "Huseynova";
            ry.age = 31;


            
            string[] fruits = new string[5];
            string[] cars = { "toyota", "nissan" };

            Person[] people = new Person[2];



            #endregion

            #region bookExample

            Book book1 = new Book();
            book1.name = "Sefiller";
            book1.author = "Viktor Huqo";
            book1.pageSize = 500;
            book1.year = 1700;

            string b1Name = book1.GetFullName();

            Book book2 = new Book();

            book2.name = "Sherlok Holmes";
            book2.author = "Sherlok";
            book2.pageSize = 150;
            book2.year = 1800;

            string b2Name = book2.GetFullName();


            Console.WriteLine(b1Name);
            Console.WriteLine(b2Name);

            Book[] books = new Book[2];
            books[0] = book1;
            books[1] = book2;
            foreach (var book in books)
            {
                Console.WriteLine(book.GetFullName());
            }

#endregion 


        }
    }
    class City
    {
       public string name;
        public double temprature;

    }
}
