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
          #region SonsuzSaatDovru  
            for(; ;)
            // ve ya for (; 1==1;)
            // ve ya (; true;)
            {
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff"));
            }
             # endregion
                 
           #region whileLoop
               double i = 5;
                           
               while (i>=0)
               {
               Console.WriteLine(i);
                   i = i -1.5;
               }
               
            #endregion
                
            #region doWhileLoop
                double i=0;
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
               
               
          #region example2
            
          // 3 reqemli eded verilib. Bu ededin axirina hemin ededin ozunu yapishdir. example: 333 = 333333     
               
         //3reqemli oldugunu yoxlayaq
               
           int t = 333;
            int e = 0;
            if (t>=100 && t<1000)
            {
                e *= 1000;
                e = e+t
               // asagi xette dusende t-nin qiymeti deyiser deye t = t *1000 +t  olarsa onda istenilen cavab alinacaq. amma t = t *1000 yazib asagi xette dusub t = t + t yazsaydiq ferqli cavab alacaydiq
                    Console.WriteLine(e)
            }
               
               
          #endregion
                   
          #region istifadeciTerefindenDaxilEdilmesi
              Console.Write("Adinizi daxil edin");
              string name = Console.ReadLine()
              Console.Write("Soyadinizi daxil edin")
              string surname = Console.ReadLine()
              string message = $"salam {name} {surname}!";
            Console.Clear();
            
            Console.WriteLine (message);
            
           #endregion
               
        #region basicCalc
               
           Console.Write ("a-ni daxil edin");
         double k = Convert.ToDouble (Console.ReadLine());
            
            Console.Write ("Emeliyyati Secin: ( +, -, *, / ) ");
            string @operator = Console.ReadLine();
            
            
            Console.Write ("b-ni daxil edin");
            double y = Convert.ToDouble(Console.ReadLine());
            
            
            double z = 0;
            
            
            if (@operator == "+")
            {
              z = k + y;  
            }
             
             else if (@operator == "-")
            {
              z = k - y;  
            }
            
            else if (@operator == "/")
            {
              z = k / y;  
            }
            
            else if (@operator == "*")
            {
              z = k * y;  
            }
            
            else {
               Console.WriteLine ("duzgun secim deyil");
            }
            
            Console.WriteLine ($"{k} {@operator} {y} = {z}")
                
         #endregion
               
         
         #region example3
                
                
         Console.Write ("a: ");
            
         string fStr = Console.ReadLine();
          double f =  Convert.ToDouble(fStr);
            
         Console.Write ("g: ")
             
           string gStr = Console.ReadLine();
            double g = Convert.ToDouble (gStr);
            
            double cavab = Math.Pow (f, g); //f-i g qeder quvvetlendir
            
            //kok alma
            
            double kokaltiCvb= Math.Pow(f, 1/g);
            
            Console.WriteLine ($"{f} ustu {g} = {cavab}");
            Console.WriteLine ($"{f}in {g} dereceden koku = {kokaltiCvb});
                               
           double kokalti = Math.Sqrt(f);
           Console.WriteLine(kokalti);
            double siniusCvb = Math.Sin();
                         
         #endregion
         
                               
          #region example4
                               
          Step1:                     
          Console.WriteLine ("n: );  
          int n = Convert.ToInt32 (Console.ReadLine());
          
          if (n >=100 && n <1000)
          {
            System.Console.WriteLine ("3 reqemli ededdir");  
          }
          else {
              
          System.Console.WriteLine ("3 reqemli eded deyil");
              
          goto Step1;
              
          }
           Step2:                      
           Console.Write (" 4 reqemli m ededi daxil edin:  ");
                             
           double m = Convert.ToDouble (Console.ReadLine ());
           if (m >=1000 && m<9999)
                             
          {
           Console.WriteLine ("4 reqemlidir");
         }
          else {
            Console.WriteLine ("4 reqemli eded deyil");
              goto Step2;
          }                
          #endregion   
                             
          
           #region Example5
            
           int ch = 12345;
            int qaliq;                 
            int cem = 0;                         
           while (ch >0){
            qaliq = ch % 10;
          Console.WriteLine (qaliq);
               ch = ch/10;
           cem = cem + qaliq;
         }
         
           Console.WriteLine )$" cem: {cem}");                  
                             
           #endregion 
               
               
         #region example6
               System.Console.WriteLine ("boyuk serheddi qeyd edin: ");
         int iStart = Convert.toInt32(Console.ReadLine());
           System.Console.WriteLine ("kicik serheddi qeyd edin: "); 
          int iEnd = Convert.ToInt (Console.ReadLine());  
        
         Console.WriteLine ($"Seciminiz: {iStart}, {iEnd}")   
           
            
            for (int i = 50; i>0; i--)
            
        {
                 if (i == 0)
            {
                continue}; // pas kecir
            /*
            continue yerine break yazsaq o zaman 0-a dusduyu anda ondan sonraki menfi ededleri yazmayacaq, 
            return yazsaydiq ise sonraki hecbir kod ishlemeyeceydi
            */
         
         if (i % 3 == 0 && i % 7==0) {
            Console.WriteLine(i); 
         }     
        }
         
            Console.WriteLine ("For dovrunden kenardaki kod");
          #endregion     
          
              
    #region example7
     int rqm = 12345;
     int reverseRqm = 0;
            
     while (rqm>0)
     {
      int galig =  rqm % 10;
        reverseRqm = reverseRqm *10 + galig; 
      Console.WriteLine (reverseRqm);
        rqm = rqm/10; 
     }
    #endregion          
      
        
     #region example8   
        
      #endregion  
        }
    }
}
