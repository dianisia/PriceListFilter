using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LinqToExcel;
using System.Globalization;
using Excel;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace PriselistFilter
{
    public class ProviderXlsWorker: XlsInterface
    {
        private List<SaleEntity> xlsData = new List<SaleEntity>();
        private List<SaleEntity> filteredData = new List<SaleEntity>();
        private Messenger messenger = new Messenger();
        public ProviderXlsWorker(string fileName)
        {
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            excelReader.IsFirstRowAsColumnNames = true;
            DataSet result = excelReader.AsDataSet();
            CreateXlsData(result);
        }

        public List<SaleEntity> getXlsData()
        {
            return filteredData.Count == 0 ? xlsData: filteredData;
        }

        public void setXlsData(List<SaleEntity> newData)
        {
            xlsData = newData;
        }

        private void CreateXlsData(DataSet result)
        {
            var table = result.Tables[0];
            for (int i = 0; i < table.Rows.Count; ++i )
            {
                var manufactor = table.Rows[i][0].ToString().Trim();
                var article = table.Rows[i][1].ToString().Trim();
                var fullName = table.Rows[i][2].ToString().Trim();
                var price = table.Rows[i][5].ToString().Trim();
                var quantity = table.Rows[i][6].ToString().Trim();
                xlsData.Add(new Product(manufactor, article, fullName, price, quantity));  
            }
        }

        public void FilterRowsByManufactor(string[] keywords)
        {
            if (filteredData.Count == 0)
            {
                filteredData = xlsData.Where(o => keywords.Contains(o.Manufactor.ToLower())).ToList();
            }
            else
            {
                filteredData = filteredData.Where(o => keywords.Contains(o.Manufactor.ToLower())).ToList();
            }
            messenger.ShowMessage("Данные по имени успешно отфильтрованы. Всего записей: " + filteredData.Count, "Результат фильтрации");
        }

        public void FilterRowsByName(string[] keywords, string[] notIncludeKeywords)
        {
            if (filteredData.Count == 0)
            {
                filteredData = xlsData.Where(o => keywords.Intersect(o.FullName.ToLower().Split(' ')).ToList().Count > 0 &&
                                         notIncludeKeywords.Intersect(o.FullName.ToLower().Split(' ')).ToList().Count == 0)
                                         .ToList();
            }
            else
            {
                filteredData = filteredData.Where(o => keywords.Intersect(o.FullName.ToLower().Split(' ')).ToList().Count > 0 &&
                                         notIncludeKeywords.Intersect(o.FullName.ToLower().Split(' ')).ToList().Count == 0)
                                         .ToList();
            }
            messenger.ShowMessage("Данные по имени успешно отфильтрованы. Всего записей: " + filteredData.Count, "Результат фильтрации");
        }

        public void FilterRowsByName(string[] keywords)
        {
            if (filteredData.Count == 0)
            {
                filteredData = xlsData.Where(o => keywords.Intersect(o.FullName.ToLower().Split(' ')).ToList().Count > 0)
                                         .ToList();
            }
            else
            {
                filteredData = filteredData.Where(o => keywords.Intersect(o.FullName.ToLower().Split(' ')).ToList().Count > 0)
                                         .ToList();
            }
            messenger.ShowMessage("Данные по имени успешно отфильтрованы. Всего записей: " + filteredData.Count, "Результат фильтрации");
        }

        public void SaveFile(string fileName)
        {
            var csv = new StringBuilder();
            PropertyInfo[] properties = typeof(Product).GetProperties();

            for (int i = 0; i < filteredData.Count; i++)
            {
                var newLine = "";
                foreach (PropertyInfo propertyInfo in properties)
                {
                    newLine += propertyInfo.GetValue(xlsData[i]) + ";";
                }
                csv.AppendLine(newLine);
            }
            File.WriteAllText(fileName, csv.ToString(), Encoding.Default);
        }
    }
}
