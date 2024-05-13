namespace HeapSort
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { -1, 10, 20, 30, 25, 5, 40, 35 };
			CreatingHeap(arr, arr.Length - 1);

			foreach (int i in arr)
			{
				if(i != -1) 
				{
                    Console.Write(i + " ");
                }
			}
		}



		static void CreatingHeap(int[] arr,int n)
		{
			for(int i = 2; i <= n; i++)
			{
				Insert(arr, i);
			}


			//sorting using deletion method
			for(int i = n; i>1; i--)
			{
				Delete(arr, i);
			}

		}


		static void Insert(int[] arr, int n)
		{
			int temp, i = n;
			temp = arr[i];

			while(i>1 && temp > arr[i / 2])
			{
				arr[i] = arr[i / 2];
				i = i / 2;
			}

			arr[i] = temp;
		}

		static void Delete(int[] arr, int n)
		{
			//swaping last element to first element
			int firstElement = arr[1];
			arr[1] = arr[n];
			arr[n] = firstElement;
			//-----end deletion-----

			//adjustment
			int i, j;
			i = 1;
			j = 2*i;

			while (j < n - 1)
			{
				if (arr[j+1]> arr[j])
				{
					j = j + 1;
				}


				if (arr[i] < arr[j])
				{
					int temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp;
					i = j;
					j = 2 * j;
				}
				else
				{
					break;
				}
			}
		}
	}
}
