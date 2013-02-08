using System;
using System.Collections;

public class Hashes
{
	public static void Main()
	{	
		string name = "";
		int x = 0;
		Hashtable hash = new Hashtable();


		while (x < 3)
		{	
			Console.WriteLine("Give me someone you know name: ");
			name = Console.ReadLine();
			Console.WriteLine("Now give me their age: ");
			hash[name] = Console.ReadLine();
			

			foreach (DictionaryEntry hashEntry in hash)
			{
				Console.WriteLine("{0}, {1}", hashEntry.Key, hashEntry.Value);
			}
			x = x + 1;
		}
						
	}	
}
