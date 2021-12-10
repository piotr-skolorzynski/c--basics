using System;
using System.Collections.Generic;
using System.Text;

namespace FirtsProject
{
	abstract class File
	{
		public string FileName { get; set; }
		public int Size { get; set; }
		public DateTime CreatedOn { get; set; }

		//example of abstract method
		public abstract void Compress();
	}
}

