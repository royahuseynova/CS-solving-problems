using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork8
{
    internal class Array
    {
        public static int Arr(int[] arr)
        {
            int arrCem = 0;

            for (int i =0; i < arr.Length; i++)
            {
                arrCem = arrCem + arr[i];
            }
            return arrCem;
        }
    }
}
