using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class CarClass
    {
        public string brand;
        public string model;
        public int productionDate;
        public string color;
        public double price;

        public string GetCar()
        {
            return $"{brand}, {model}, {productionDate}, {color}, {price}";
        }
    }
}
