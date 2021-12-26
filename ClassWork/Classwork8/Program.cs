using MyHelpers;
using System;

namespace Classwork8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = Readers.ReadInteger("1ci ededi daxil edin: ");
            int num2 = Readers.ReadInteger("2ci ededi daxil edin: ");

            int sum = Calculator.Topla(num1, num2);
            int deduction = Calculator.Ferq(num1, num2);
            int multiply = Calculator.Hasil(num1, num2);
            Calculator calc = new Calculator();
            double division = calc.Nisbet(num1, num2);
            int[] mass =  new int []{ 1,2,3,14,5};
            int arrCem = Array.Arr(mass);


            Console.WriteLine(sum);
            Console.WriteLine(deduction);
            Console.WriteLine(multiply);
            Console.WriteLine(division);
            Console.WriteLine(arrCem);

        }
    }
}
