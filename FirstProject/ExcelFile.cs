using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class ExcelFile : File
	{

		public void GenerateReport()
        {
			Console.WriteLine($"{FileName} report ...");
        }

		//implementation of abstract method 
		public override void Compress()
        {
			Console.WriteLine("Compressing ExcelFile");
        }
	}

}

