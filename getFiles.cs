using System.IO;

public class getFiles
{
	public static void Main()
	{
		System.Console.WriteLine("Enter Path: ");
		string input = System.Console.ReadLine();
		System.Console.WriteLine("What file extension would you like to see: ");
		string ext1 = System.Console.ReadLine();
		string[] ext2 = ext1.Split(',');
		
		
		foreach (string e in ext2)
		{
			foreach( string f in Directory.GetFiles(input, e) )
			{
				System.Console.WriteLine("> " + f);
			}
		}

	}
}

