namespace SelectionSort
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 1,3,5,2,};
			SelectionSort(arr); // O ( n 2 ) 

			for (int i = 0; i<arr.Length; i++)
			{
				Console.WriteLine(arr[i]);
			}
		}

		static void SelectionSort(int[] arr)
		{
			for (int i = 0; i<arr.Length; i++)
			{
				int minIndex = i;

				for (int j = i+1; j < arr.Length; j++)
				{
					if (arr[j] < arr[minIndex])
					{
						minIndex = j;
					}
				}

				int temp = arr[i];
				arr[i] = arr[minIndex];
				arr[minIndex] = temp;
			}
		}
	}
}
