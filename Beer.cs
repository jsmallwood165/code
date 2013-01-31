public class Beer
{
	public static void Main()
	{
		string Firts, Middle, Last;

		First = System.Console.ReadLine ("What is your first name: ");
		Middle = System.Console.ReadLine ("What is your middle name: ");
		Last = System.Console.Readline ("What is your last name: ");

		System.Console.WriteLine (" Now I will take you name and print it backwards.");
	
		Drunk(Firts, Middle, Last);
	}

	public class void Drunk(string f, m, l)
	{
		string [] arr1 {f, m, l};

		int x;

                for (x = arr1.Length - 1; x >= 0; x--)
                {
                        System.Console.WriteLine ("here you go " + arr[x]);
                }
	}
}

	
