public class Doo
{
	public static void Main()
	{
		string name = "Jason";
		int x = 6;

		while (x < 22)
		{
			System.Console.WriteLine ("who is " + name);
			x = x + 2;
		}
		
		ShowEven();

		
	}

	public static void ShowEven()
	{
		for (int i = 0; i <= 100; i++)
		{
			if ((i % 2) == 1)
			{
				 
				System.Console.WriteLine ("show me " + i);
			}
	
		}
	}
}

