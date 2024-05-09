namespace BubbleSort
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] a = {0,1,2,2,3,8,7};	
			bubbleSort(a);//O(n2)
			foreach (int i in a)
				Console.WriteLine(i);

		}

		static void bubbleSort(int[] arr)
		{
			for (int i = 0; i <arr.Length; i++)
			{
				bool flag =  false;
				for(int j = 0;j<arr.Length-i-1; j++)
				{
					if (arr[j + 1] < arr[j])
					{
						int temp = arr[j + 1];
						arr[j+1] = arr[j];
						arr[j] = temp;
						flag = true;
					}
				}

				if (!flag)
				{
					break;
				}
			}
        }
	}
}
