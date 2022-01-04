using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork13
{
    internal class Car
    {
        public string marka;
        public string model;
        public int year;


        public Car()
        {
            Console.WriteLine("ctor ile yeni nusxe yaradildi");
        }

       /* public Car()
        {
            Console.WriteLine("Yeni masin nusxesi yaradildi");
        } */

        public void Start()
        { 
            Console.WriteLine("Engine started");
        }
        public void Move()
        {
            Console.WriteLine($"{marka}/{model}/{year} moved");
        }
        public void Stop()
        {
            Console.WriteLine("Car stopped");
        }
        public override string ToString()
        {
            return $"{marka}/{model}/{year}";
        }
        public string GetFullName()
        {
            return $"{marka}/{model}/{year}".ToUpper();
        }
    }
}
