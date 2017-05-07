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

namespace PriselistFilter
{
    public class XlsWorker
    {
        private List<Product> xlsData;
        private List<Product> filteredData;
        public XlsWorker(string filename)
        {
            FileStream stream = File.Open(filename, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            excelReader.IsFirstRowAsColumnNames = true;
            DataSet result = excelReader.AsDataSet();
            CreateXlsData(result);
        }

        private void CreateXlsData(DataSet result)
        {
            var table = result.Tables[0];
            xlsData = new List<Product>();
            for (int i = 0; i < table.Rows.Count; ++i )
            {
                var manufactor = table.Rows[i][0].ToString();
                var article = table.Rows[i][1].ToString();
                var fullName = table.Rows[i][2].ToString();
                var measure = table.Rows[i][3].ToString();
                var mult = table.Rows[i][4].ToString();
                var price = table.Rows[i][5].ToString();
                var balance = table.Rows[i][6].ToString();
                xlsData.Add(new Product(manufactor, article, fullName, measure, mult, price, balance));  
            }
        }

        public void FilterRowsByManufactor(string[] keywords)
        {
            filteredData = xlsData.Where(o => keywords.Contains(o.Manufactor)).ToList();
        }

        public void SaveFile()
        {
            var csv = new StringBuilder();
            PropertyInfo[] properties = typeof(Product).GetProperties();

            for (int i = 0; i < filteredData.Count; i++)
            {
                var newLine = "";
                foreach (PropertyInfo propertyInfo in properties)
                {
                    newLine += propertyInfo.GetValue(filteredData[i]) + ";";
                }
                csv.AppendLine(newLine);
            }
            File.WriteAllText("result.csv", csv.ToString(), Encoding.Default);
        }
    }
}
