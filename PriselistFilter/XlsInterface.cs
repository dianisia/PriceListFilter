using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriselistFilter
{
    public interface XlsInterface
    {
         //void CreateXlsData(DataSet result);
         void FilterRowsByManufactor(string[] keywords);
         void FilterRowsByName(string[] keywords, string[] notIncludeKeywords);
         void FilterRowsByName(string[] keywords);
         void SaveFile(string fileName);
         List<SaleEntity> getXlsData();
         void setXlsData(List<SaleEntity> newData);
    }
}
