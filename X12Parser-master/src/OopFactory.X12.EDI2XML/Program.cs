using System;
using System.IO;
using OopFactory.X12.Parsing;
using OopFactory.X12.Parsing.Model;
using OopFactory.X12.X12Parser;

namespace OopFactory.X12.EDI2XML
{

	public class Program
	{

		static void Main(string[] args)
		{
			//Console.Write("Input X12 File Name:");
			//string fname = Console.ReadLine();
			//FileStream fstream = new FileStream(fname, FileMode.Open, FileAccess.Read);
			//Console.WriteLine();
			var parser = new X12Parser();
			string x12 = parser.x12.get;
			//File fname = ;
			FileStream fstream = new FileStream(x12, FileMode.Open, FileAccess.Read);
			Interchange interchange = parser.Parse(fstream);
			string xml = interchange.Serialize();

		}
	}
}

