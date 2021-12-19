using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork4
{
    internal class Book

    {
        public string name;
        public string author;
        public int pageSize;
        public int year;

        public string GetFullName()
        {
            return $"{name} : {author} : {pageSize}: {year}";
        }
    }
}
