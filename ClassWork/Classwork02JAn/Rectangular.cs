using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork02JAn
{
    public class Rectangular
    {
        
        public double width;
        public double length;

        public double En { get { return width; }
            set {
                if (value<1) {
                    throw new Exception($"get set icindeki yanlis {value}");
                }
                width = value; } }
        public double Uzunluq { get { return length; }
            set {
                if (value < 1) {
                    throw new Exception($"property icindeki yanlis uzunluq{value}");
                }
                length = value; } }



        public Rectangular(double w, double l)
        {if (w < 1)
            {
                throw new Exception("yanlis, exception ");
            }
            width = w;
            length = l;
        }
       public Rectangular()
        {
            Console.WriteLine("bos ctor");
        }
        public double Perimeter()
        {
            return 2 * (width + length);
        }
        public double Area()
        {
            return width * length;
        }
    }
}
