namespace BinaryToDecimal
{
	public class Program
	{
		static void Main(string[] args)
		{
			int.TryParse(Console.ReadLine(), out int num);
			int number = num;
            Console.WriteLine(ConvertIntoBinary(number));
        }

		public static string ConvertIntoBinary(int num)
		{
			string binaryStr = string.Empty;
			while(0<num)
			{
				binaryStr += num % 2;
				num = num / 2;
			}

            char[] binaryArray = binaryStr.ToCharArray();
			Array.Reverse(binaryArray);
			return new String(binaryArray);
		}
	}


}
