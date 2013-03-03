using System;
using System.IO;

public class stage2
{
	public static void Main()
	{
		var file = File.OpenText("stage1.txt");

		Console.WriteLine("User name: ");
		string name = Console.ReadLine();

		while(!file.EndOfStream)
		{
			string Line = file.ReadLine();
			
			if (Line.Contains(name))
			{
				string[] pair = Line.Split(' ');
				Console.WriteLine("{0} is {1} years old", pair[0], pair[1] );
			}
		}
	}
}
