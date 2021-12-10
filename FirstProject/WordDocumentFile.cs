using System;

namespace FirstProject
{
	public class WordDocumentFile
	{
		public string FileName { get; set; }
		public int Size { get; set; }
		public DateTime CreatedOn { get; set; }

		public void Print()
		{
			Console.WriteLine($"{FileName} printing ...");
		}
	}

}