using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriselistFilter
{
    public class Comparator
    {
        private double markup = 0;
        private int newItems = 0;
        private int changedItems = 0;
        private int deletedItems = 0;
        private Messenger messenger = new Messenger();
        public Comparator(double _markup)
        {
            markup = _markup;
        }
        public void Compare(XlsInterface a, XlsInterface b)
        {
            var myData = a.getXlsData();
            var providerData = b.getXlsData();
            foreach (var item in myData)
            {
                var providerProduct = providerData
                        .Where(e => e.Article.Equals(item.Article, StringComparison.OrdinalIgnoreCase))
                        .FirstOrDefault();

                if (providerProduct != null)
                {
                    changedItems++;
                    var price = providerProduct.Price;
                    item.Price = Convert.ToInt32(Math.Ceiling(price + price * (markup / 100)));
                    item.Quantity = providerProduct.Quantity;
                }
                else
                {
                    deletedItems++;
                    item.Quantity = 0;
                }
            }

            var lastProductId = Convert.ToInt32(myData.Last().ProductId);

            myData.Add(new Item("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""));


            foreach (var item in providerData)
            {
                var newProduct = myData
                                .Where(e => e.Article.Equals(item.Article, StringComparison.OrdinalIgnoreCase))
                                .FirstOrDefault();
                
                if (newProduct == null)
                {
                    lastProductId++;
                    newItems++;
                    double price = Math.Ceiling(item.Price + item.Price * (markup / 100));
                    myData.Add(new Item(lastProductId.ToString(), item.FullName, " ", " ", item.Article.ToString(), " ", " ", " ", " ",
                        " ", " ", item.Quantity.ToString(), item.FullName, item.Manufactor, " ", " ", price.ToString()));
                }
            }
            
            a.setXlsData(myData);
            messenger.ShowMessage("Данные сравнены с наценкой: " + markup + "% \n Новых товаров: " + newItems + "\n Измененных товаров: " + changedItems
                + "\n Удаленных товаров: " + deletedItems, "Результат сравнения");
        }
        
    }
}
