using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using FirstProject.ExcelFile;
using FirstProject.WordDocumentFile;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelFile excelFile = new ExcelFile();
            excelFile.FileName = "excel-file";
            excelFile.CreatedOn = DateTime.Now;
            excelFile.GenerateReport();

            WordDocumentFile wordDocumentFile = new WordDocumentFile();
            wordDocumentFile.FileName = "word-file";
            wordDocumentFile.CreatedOn = DateTime.Now;
            wordDocumentFile.Print();
        }
    }
}


