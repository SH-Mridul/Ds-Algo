namespace GCDUsingEuclid
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a  = int.Parse(Console.ReadLine());
			int b  = int.Parse(Console.ReadLine());

			int dividend = a >= b ? a : b;
			int divisor  = b <= a ? b : a;

			while (divisor != 0) 
			{
				int reminder = dividend % divisor;
				dividend = divisor;
				divisor = reminder;
			}

            Console.WriteLine(dividend);
            Console.ReadKey();
        }
	}
}
