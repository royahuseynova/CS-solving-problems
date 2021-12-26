using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHelpers
{
    public class Calculator
    {
        
            public static int Topla(int eded1, int eded2)
            {
                int cem = eded1 + eded2;

                return cem;
            }

            public static int Ferq(int eded1, int eded2)
            {
                int ferq1 = eded1 - eded2;
                return ferq1;

            }

            public static int Hasil(int eded1, int eded2)
            {
                int hasil = eded1 * eded2;
                return hasil;
            }
            public  double Nisbet(double eded1, double eded2)
            {
                double nisbet = eded1 / eded2;
                return nisbet;
            }


        }
    
}
