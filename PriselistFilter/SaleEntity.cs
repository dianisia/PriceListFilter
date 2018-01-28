using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriselistFilter
{
    public class SaleEntity
    {
        public string FullName { get; set; }
        public string Manufactor { get; set; }

        public string Article { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public string ProductId { get; set; }

        public string Categories { get; set; }

        public string MainCategory { get; set; }

        public string Upc { get; set; }

        public string Ean { get; set; }
        public string Jan { get; set; }
        public string Isbn { get; set; }
        public string Mpn { get; set; }
        public string Location { get; set; }
        public string Model { get; set; }
        public string ImageName { get; set; }
        public string Shipping { get; set; }
    }
}
