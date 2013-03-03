using System;
using System.IO;


public class stage1
{
	public static void Main()
	{

		Console.WriteLine("User Name: ");
		string user = Console.ReadLine();

		Console.WriteLine("What is your age: ");
		string age = Console.ReadLine();
		int age1 = Convert.ToInt32(age);

		string both = user + " " + (int)age1 + "\n";
	
		File.AppendAllText(@"/home/brock/Documents/stage1.txt", both );

	}
}
