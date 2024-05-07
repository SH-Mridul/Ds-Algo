namespace PrimeFactorization
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			int n = number;

			for(int i = 2; i <= Math.Sqrt(n); i++)
			{
				if(n % i == 0)
				{
					int count = 0;
					while(n % i == 0)
					{
						n = n / i;
						count++;
					}

                    Console.WriteLine(i+"^"+count);
                }
			}

			if(n != 1) Console.WriteLine(n+"^"+1);
			Console.ReadKey();
        }
	}
}
