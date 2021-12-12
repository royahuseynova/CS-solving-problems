using System;

namespace Classwork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Arif";
            string surname = "Abbasov";

            //string fullName = name + " "+surname;

            string fullName = $"{name} {surname}";
           Console.WriteLine(fullName);


            


            Console.ReadKey();

        }
    }
}
