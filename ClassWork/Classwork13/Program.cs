using System;

namespace Classwork13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car honda = new Car();
            honda.marka = "Honda";
            honda.model = "civic";
            honda.year = 2008;
            honda.Start();
            honda.Move();
            honda.Stop();

            Car ferrari = new Car();
            ferrari.marka = "Ferrari";
            ferrari.model = "F8";
            ferrari.year = 2011;
            ferrari.Start();
            ferrari.Move();
            ferrari.Stop();
            Console.WriteLine("____________");
            Console.WriteLine(honda);
            Console.WriteLine(ferrari);
        }
    }
}
