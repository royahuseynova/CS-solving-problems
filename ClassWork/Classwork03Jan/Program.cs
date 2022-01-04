using System;
using Classwork02JAn;
using Classwork03Jan.Example1;

namespace Classwork03Jan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Rectangular rect = new Rectangular();
             rect.En = 300;
             rect.Uzunluq = 200;

             Console.WriteLine(rect.Perimeter()); */


            Devop d = new Devop();
            Doctor doc = new Doctor();

            d.name = "Islam";
            d.surname = "Husyenli";
            d.Speak();
            d.WriteCode();

            doc.name = "Hekim";
            doc.surname = "Baba";
            doc.Speak();
            doc.Heal();
        }
    }
}
