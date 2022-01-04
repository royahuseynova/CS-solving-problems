using System;

namespace Classwork02JAn
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangular rect = new Rectangular();
            rect.En = -400;
            rect.Uzunluq = 100;

            Console.WriteLine($"Perimeter: {rect.Perimeter()}");
            Console.WriteLine($"Area: {rect.Area()}");

            try { 
            Rectangular rect2 = new Rectangular(100, 200);
            Console.WriteLine($"PErimeter 2 :{rect2.Perimeter()}");
            Console.WriteLine($"Area 2 : {rect2.Area()}"); }
        catch (Exception sehv){
                throw;
            }

        }
    }
}
