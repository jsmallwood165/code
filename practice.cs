public class practice
{
	public static void Main()
	{
		int i = 0;
		int count = 0;
		int result = 0;

		while (i < 10)
		{
			count = count + 1;
			i = i + 1;
		}
		
		for (int h = 1; h < 5; h++)
		{
			count = count - 1;
			result = count;
		}
	
		System.Console.WriteLine("End is: " + result);
	}
}
