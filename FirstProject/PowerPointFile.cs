using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class PowerPointFile : File
	{

		public void Present()
		{
			Console.WriteLine($"{FileName} presenting ...");
		}

		//implementation of abstract method 
		public override void Compress()
		{
			Console.WriteLine("Compressing PowerPointFile");
		}
	}

}
