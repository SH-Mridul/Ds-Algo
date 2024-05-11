namespace MargeSort
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 5, 9, 1, 3, 7, 10 };
			Sort(arr, 0,arr.Length-1);

			foreach (int i in arr)
			{
				Console.WriteLine(i);
			}
		}


		//marging the array
		static void Marge(int left, int mid, int right, int[] arr)
		{
			int leftN = mid - left + 1; //left array size;
			int rightN = right - mid; //right array size;

			//creating temp array
			int[] leftArray = new int[leftN];
			int[] rightArray = new int[rightN];

			//index
			int i = 0;
			int j = 0;


			//copy data into main array to temp array
			for (i = 0; i < leftN; i++)
				leftArray[i] = arr[left+i];

			for (j = 0; j < rightN; j++)
				rightArray[j] = arr[mid+1+j];

			i = j = 0;//making i,j zero again

			//marge the temp array
			int k = left;

			while (i < leftArray.Length && j < rightArray.Length)
			{
				if (leftArray[i] < rightArray[j])
				{
					arr[k] = leftArray[i];
					i++;
				}
				else
				{
					arr[k] = rightArray[j];
					j++;
				}

				k++;
			}


			//left copy remaining elements
			while(i < leftArray.Length)
			{
				arr[k] = leftArray[i];
				k++;
				i++;
			}

			//right copy remaining elements
			while (j < rightArray.Length)
			{
				arr[k] = rightArray[j];
				k++;
				j++;
			}
		}


		//spliting array
		public static void Sort(int[] arr, int left,int right)
		{
			if (left < right)
			{
				//mid value calculation
				int mid = left + (right - left) / 2;

				//sort first and second half
				Sort(arr, left, mid);
				Sort(arr, mid + 1, right);

				//marge splited array
				Marge(left, mid, right, arr);
			}
		}
	}
}
