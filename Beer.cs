public class Beer
{
	public static void Main()
	{
		string First, Middle, Last;

		System.Console.WriteLine ("What is your first name: ");
		First = System.Console.ReadLine ();
		System.Console.WriteLine ("What is your middle name: ");
		Middle = System.Console.ReadLine();
		System.Console.WriteLine ("What is your last name: ");
		Last = System.Console.ReadLine();
		System.Console.WriteLine (" Now I will take you name and print it backwards.");
	
		Drunk(First, Middle, Last);
	}

	public static void Drunk(string f, string m, string l)
	{
		string []  arr1 =  {f, m, l};

		int x;

                for (x = arr1.Length - 1; x >= 0; x--)
                {
                        System.Console.WriteLine ("here you go " + arr1[x]);
                }
	}
}

	
