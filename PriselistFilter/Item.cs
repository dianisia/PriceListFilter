using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriselistFilter
{
    public class Item : SaleEntity
    {
        public Item(string productId, string name, string categories, string mainCategory, string sku, 
            string upc, string ean, string jan, string isbn, string mpn, string location, string quantity,
            string model, string manufactor, string imageName, string shipping, string price)
        {
            ProductId = productId;
            FullName = name;
            Categories = categories;
            MainCategory = mainCategory;
            Article = sku;
            Upc = upc;
            Ean = ean;
            Jan = jan;
            Isbn = isbn;
            Mpn = mpn;
            Location = location;
            Quantity = quantity == "" ? 0 : Int32.Parse(quantity);
            Model = model;
            Manufactor = manufactor;
            ImageName = imageName;
            Shipping = shipping;
            Price = price == "" ? 0 : (int) Math.Ceiling(float.Parse(price, CultureInfo.InvariantCulture));
        }
    }
}
