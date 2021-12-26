using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHelpers
{
    public class Readers
    {
        public static int ReadInteger(string caption)
        {
            int a;
        readAgain:
            try
            {
                Console.Write(caption);
                a = Convert.ToInt32(Console.ReadLine());
                return a;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Yeniden cehd edin!");
                goto readAgain;
            }
        }
        public static string ReadString(string caption)
        {
        readAgain:
            try
            {
                Console.WriteLine(caption);
                string a = Console.ReadLine();
                if (a.Length <= 1)
                {

                    Console.WriteLine("Yeniden cehd edin");
                    goto readAgain;
                }
                return a;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Yeniden cehd edin");
                goto readAgain;
            }
        }
    }
}
