using System;


namespace Classwork5
{
    internal class Program
    {
        static void Main(string[] args)

        {

           
            int resul =  Topla(20, 15);
            Console.WriteLine(resul);

            string msj = PrintMessage("salam");

            
            static int Topla(int a, int b) {
             
                return a + b;
            }

            int x = 10;
            int y = 12;      
            int e = Multiply(x,y);
            Console.WriteLine(e);

            static string PrintMessage(string a)
            {
                
                return a;
            }

            int d = 40;
            Console.WriteLine(d);
          
            Console.WriteLine(d);

            int[] chy = { 1, 2, 3, 4, 5, 6 };
            foreach (int item in chy)
            {
                Console.WriteLine(item);
            }
            AddOne(chy);
            foreach(int item in chy)
            {
                Console.WriteLine(item);
            }
        }
       
        static void AddOne(int[] b)
        {
            for (int i = 0; i<b.Length; i++)
            {
                b[i] = b[i] + 1;
            }
            Console.WriteLine(b);
        }
          static int Multiply(int a, int b)
        {
            int hasil = a * b;
            return hasil;
        } 


        }
    }

