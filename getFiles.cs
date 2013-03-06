using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic.IEnumerable;

public class getFiles
{
	public static void Main()
	{
		System.Console.WriteLine("Enter Path: ");
		string input = System.Console.ReadLine();
		System.Console.WriteLine("What file extension would you like to see: ");
		string ext1 = System.Console.ReadLine();
		string[] ext2 = ext1.Split(',');

		SortedDictionary<int, string> map = new SortedDictionary<int, string>();
		
		
		foreach (string e in ext2)
		{
			foreach( string f in Directory.GetFiles(input, e) )
			{
				FileInfo f1 = new FileInfo (f);
				map.Add(Convert.ToInt32(f1.Length), f);	
			}
	
		}

		foreach (var a in map)
		{
			Console.WriteLine("{1} \tis {0} bytes", a.Key, a.Value);
		}
	}
}

