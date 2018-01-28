using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using LinqToExcel.Attributes;

namespace PriselistFilter
{
    public class Product: SaleEntity
    {
        public Product(string manufactor, string article, string fullname, string price, string quantity) 
        {
            Manufactor = manufactor;
            Article = article;
            FullName = fullname;
            Price = price == "" ? 0 : (int) Math.Ceiling(Double.Parse(price));
            Quantity = quantity == "" ? 0 : Int32.Parse(quantity);
            ProductId = "";
            Categories = "";
            MainCategory = "";
            Upc = "";
            Ean = "";
            Jan = "";
            Isbn = "";
            Mpn = "";
            Location = "";
            Model = "";
            ImageName = "";
            Shipping = "";
        }
    }
}
