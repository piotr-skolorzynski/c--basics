﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
	class WordDocumentFile : File
	{

		public void Print()
		{
			Console.WriteLine($"{FileName} printing ...");
		}
	}

}