using System;
using System.Collections;

public class Hashes
{
	public static void Main()
	{	
		string name = "";
		
		
		Hashtable hash = new Hashtable();
		Console.WriteLine("Give me your grandfathers name: ");
		name = Console.ReadLine();
		Console.WriteLine("Give me your grandfathers age: ");
		hash[name] = Console.ReadLine();

		//Console.WriteLine("Give me your fathers age: ");
		//hash[2] = Console.ReadLine();
		//Console.WriteLine("Give me your brothers age: ");
		//hash[3] = Console.ReadLine();

		foreach (DictionaryEntry hashEntry in hash)
		{
			Console.WriteLine("{0}, {1}", hashEntry.Key, hashEntry.Value);
		}			
	}	
}
