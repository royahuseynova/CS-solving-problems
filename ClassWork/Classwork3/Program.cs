using System;

namespace Classwork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int b =1;
            for (int i = 5; i >=1; i--)
            {
            b = b *i;
            }
          #region Sonsuz saat dovru  
            for(; ;)
            // ve ya for (; 1==1;)
            // ve ya (; true;)
            {
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff"));
            }
             # endregion
                 
           #region while Loop
               double i = 5;
                           
               while (i>=0)
               {
               Console.WriteLine(i);
                   i = i -1.5;
               }
               
            #endregion
                
            #region do while loop
                doubke i-0;
               do
               {
                 Console.WriteLine (i );
               } while (i>0)
            
             #endregion
                   
                   
           #region example1
                   
            // 4reqemli eded verilib, bu ededin evveline 7 reqemini , axirina 8 reqemini artir, mes: 3333 = 73338
                   
           int x = 3333; 
            
           // 4reqemli oldugunu yoxlayaq
            
           if (x >=1000 && a< 10000)
           {
            x = 70000+x; // 73333
            x = x *10; // 733330
            x = x + 8; 
            // bu ikisini qisaldib bele yazmaq olar: x *= 10
          // x += 8;
           }                   
           #endregion
               
               
           
                   
                   
        }
    }
}
