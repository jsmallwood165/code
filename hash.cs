using System.Collections.Generic;
using System.Collections;
using System;

public class mizzain
{
   public static void Main()
   {
		SortedList<int, string> people = new SortedList<int, string>();
		int x = 0;

		while( x < 3)
		{
      		Console.WriteLine("Name: ");
			string name = Console.ReadLine();

			Console.WriteLine("Age: ");
			int age = Convert.ToInt32( Console.ReadLine() );

			people.Add( age, name );

			x++;
		}
	
		foreach( KeyValuePair<int, string> p in people )
		{
			Console.WriteLine("{1} is {0} years old", p.Key, p.Value );
		}

   }
}

