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
        //[ExcelColumn("Номенклатура#Производитель")] 
        public string Manufactor { get; set; }

        //[ExcelColumn("Артикул")] 
        public string Article { get; set; }

        //[ExcelColumn("Наименование полное")] 
        public string FullName { get; set; }

        //[ExcelColumn("Единица измерения")] 
        public string Measure { get; set; }

        //[ExcelColumn("Кратность")] 
        public string Multiplicity { get; set; }

        //[ExcelColumn("Цена")] 
        public string Price { get; set; }

        //[ExcelColumn("ПредставлениеОстатка")] 
        public string Balance { get; set; }
    }
}
