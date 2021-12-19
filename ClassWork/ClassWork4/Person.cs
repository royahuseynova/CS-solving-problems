using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork4
{
    internal class Person
    {
        public string name;
        public string surname;
        public int age;


        public static void WakeUp()
        {
            Console.WriteLine("okey from Person.WakeUp");
        }
        public static void Washing()
        {
            Console.WriteLine("wash your hands");
        }
        public static void Breakfast()
        {
            Console.WriteLine("eat breakfast");
        }
    }
}
