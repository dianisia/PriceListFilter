using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriselistFilter
{
    public class MyXlsWorker : XlsInterface
    {
        private List<SaleEntity> xlsData = new List<SaleEntity>();
        private Messenger messenger = new Messenger();
        public List<SaleEntity> getXlsData()
        {
            return xlsData;
        }

        public MyXlsWorker(string fileName)
        {
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = fileName.Contains(".xlsx") ? ExcelReaderFactory.CreateOpenXmlReader(stream)
                                                                    : ExcelReaderFactory.CreateBinaryReader(stream);
            excelReader.IsFirstRowAsColumnNames = true;
            DataSet result = excelReader.AsDataSet();
            try
            {
                CreateXlsData(result);
            }
            catch (Exception exc)
            {
                messenger.ShowMessage("Возможно, выбран не тот файл,", "Что-то пошло не так!");
            }
        }
        private void CreateXlsData(DataSet result)
        {
            var table = result.Tables[0];
            for (int i = 0; i < table.Rows.Count; ++i)
            {
                var productId = table.Rows[i][0].ToString().Trim();
                var name = table.Rows[i][1].ToString().Trim();
                var categories = table.Rows[i][2].ToString().Trim();
                var mainCategory = table.Rows[i][3].ToString().Trim();
                var sku = table.Rows[i][4].ToString().Trim();
                var upc = table.Rows[i][5].ToString().Trim();
                var ean = table.Rows[i][6].ToString().Trim();
                var jan = table.Rows[i][7].ToString().Trim();
                var isbn = table.Rows[i][8].ToString().Trim();
                var mpn = table.Rows[i][9].ToString().Trim();
                var location = table.Rows[i][10].ToString().Trim();
                var quantity = table.Rows[i][11].ToString().Trim();
                var model = table.Rows[i][12].ToString().Trim();
                var manufacturer = table.Rows[i][13].ToString().Trim();
                var imageName = table.Rows[i][14].ToString().Trim();
                var shipping = table.Rows[i][15].ToString().Trim();
                var price = table.Rows[i][16].ToString().Trim();

                xlsData.Add(new Item(productId, name, categories, mainCategory, sku, upc, ean, jan, isbn,
                    mpn, location, quantity, model, manufacturer, imageName, shipping, price));
            }
        }

        public void setXlsData(List<SaleEntity> newData)
        {
            xlsData = newData;
        }

        public void UpdatePriceAndQuantity(string article, int price, int quanity)
        {
            foreach (var itemByArticle in xlsData.Where(s => s.Article == article))
            {
                itemByArticle.Quantity = quanity;
                itemByArticle.Price = price;
            }
        }

        public void FilterRowsByManufactor(string[] keywords)
        {
           xlsData = xlsData.Where(o => keywords.Contains(o.Manufactor.ToLower())).ToList();
           messenger.ShowMessage("Данные по имени успешно отфильтрованы. Всего записей: " + xlsData.Count, "Результат фильтрации");
        }

        public void FilterRowsByName(string[] keywords, string[] notIncludeKeywords)
        {
            xlsData = xlsData.Where(o => keywords.Intersect(o.FullName.ToLower().Split(' ')).ToList().Count > 0 &&
                                        notIncludeKeywords.Intersect(o.FullName.ToLower().Split(' ')).ToList().Count == 0)
                                        .ToList();
            messenger.ShowMessage("Данные по имени успешно отфильтрованы. Всего записей: " + xlsData.Count, "Результат фильтрации");
        }

        public void FilterRowsByName(string[] keywords)
        {
            xlsData = xlsData.Where(o => keywords.Intersect(o.FullName.ToLower().Split(' ')).ToList().Count > 0)
                                        .ToList();
            messenger.ShowMessage("Данные по имени успешно отфильтрованы. Всего записей: " + xlsData.Count, "Результат фильтрации");
        }

     
        public void SaveFile(string fileName)
        {
            var csv = new StringBuilder();
            PropertyInfo[] properties = typeof(Item).GetProperties();

            for (int i = 0; i < xlsData.Count; i++)
            {
                var newLine = "";
                var resultData = (Item)xlsData[i];
                newLine += resultData.ProductId + ";" + resultData.FullName + ";" + resultData.Categories +
                    ";" + resultData.MainCategory + ";" + '"' + resultData.Article + '"' + ";" + resultData.Upc +
                    ";" + resultData.Ean + ";" + resultData.Jan + ";" + resultData.Isbn + ";" + resultData.Mpn +
                    ";" + resultData.Location + ";" + resultData.Quantity + ";" + resultData.Model + ";" + resultData.Manufactor +
                    ";" + resultData.ImageName + ";" + resultData.Shipping + ";" + resultData.Price;
                csv.AppendLine(newLine);
            }
            File.WriteAllText(fileName, csv.ToString(), Encoding.Default);
        }
    }
}
