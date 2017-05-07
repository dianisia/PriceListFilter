using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using LinqToExcel.Attributes;

namespace PriselistFilter
{
    public class Product
    {
        public string Manufactor { get; set; }

        public string Article { get; set; }

        public string FullName { get; set; }

        public string Measure { get; set; }

        public string Multiplicity { get; set; }

        public string Price { get; set; }

        public string Balance { get; set; }

        public Product(string manufactor, string article, string fullname, 
                        string measure, string mult, string price, string balance) 
        {
            Manufactor = manufactor;
            Article = article;
            FullName = fullname;
            Measure = measure;
            Multiplicity = mult;
            Price = price;
            Balance = balance;
        }
    }
}
