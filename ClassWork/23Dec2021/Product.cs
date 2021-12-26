using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23Dec2021
{
    public class Product
    {
        public int Id { get; set; }
        public int StockCode { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Decimal Price { get; set; }

        public string GetPhone()
        {
            return $"{Id}: {StockCode}: {Name}: {CategoryId}: {Price}";
        }
        
    }

}
