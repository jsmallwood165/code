using System.IO;

public class getFiles
{
	public static void Main()
	{
		System.Console.WriteLine("Enter Path: ");
		string input = System.Console.ReadLine();
		string[] filePaths = Directory.GetFiles(input);

		foreach (string i in filePaths)
		{
			System.Console.WriteLine(i);
		}		
	}
}

