using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LinqToExcel;
using System.Globalization;

namespace PriselistFilter
{
    public class XlsWorker
    {
        private List<Product> xlsData;
        private List<Product> filteredData;
        public XlsWorker(string filename)
        {
            ExcelQueryFactory xlsObject = new ExcelQueryFactory(filename);
            xlsObject.AddMapping<Product>(x => x.Manufactor, "Номенклатура#Производитель");
            xlsObject.AddMapping<Product>(x => x.Article, "Артикул");
            xlsObject.AddMapping<Product>(x => x.FullName, "Наименование полное");
            xlsObject.AddMapping<Product>(x => x.Measure, "Единица измерения");
            xlsObject.AddMapping<Product>(x => x.Multiplicity, "Кратность");
            xlsObject.AddMapping<Product>(x => x.Price, "Цена");
            xlsObject.AddMapping<Product>(x => x.Balance, "ПредставлениеОстатка");

            var temp = from c in xlsObject.Worksheet<Product>()
                       select c;
            xlsData = temp.ToList();
        }

        public void FilterRowsByManufactor(string[] keywords)
        {
            filteredData = xlsData.Where(o => keywords.Contains(o.Manufactor)).ToList();
        }

        public void SaveFile()
        {
            var csv = new StringBuilder();

            for (int i = 0; i < filteredData.Count; i++)
            {
                var newLine = filteredData[i].Manufactor + ";" + filteredData[i].FullName + ";" + filteredData[i].Price;
                csv.AppendLine(newLine);
            }
            File.WriteAllText("result.csv", csv.ToString(), Encoding.Default);
        }
    }
}
