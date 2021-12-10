using System;

namespace FirstProject
{
	public class ExcelFile
	{
		public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }

		public void GenerateReport()
        {
			Console.WriteLine($"{FileName} report ...");
        }
	}

}

