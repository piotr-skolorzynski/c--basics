using System;
using System.Collections.Generic;
using System.Text;

namespace FirtsProject
{
	interface IFile
	{
		string FileName { get; set; }
		int Size { get; set; }
		DateTime CreatedOn { get; set; }
		void Compress();
	}
}

