namespace InsertionSort
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 23, 1, 10, 5, 2 };
			InsertionSort(arr);
			foreach (int i in arr)
			{
				Console.WriteLine(i);
			}
		}

		static void InsertionSort(int[] arr)
		{

			for (int i = 1; i < arr.Length; i++)
			{
				int temp = arr[i];
				int j = i - 1;
					
				while(j >= 0 && arr[j] > temp)
				{
					arr[j+1] = arr[j];
					j--;
				}

				arr[j+1] = temp;
			}
		}
	}
}
