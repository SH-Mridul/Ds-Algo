using System;

namespace QuickSort
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 5,3,7,4,1,0};
			QuickSort(arr, 0,arr.Length-1) ;

			foreach(int i in arr)
			{
				Console.WriteLine(i) ;
			}
		}

		static void QuickSort(int[] arr,int start,int end)
		{
			if (start < end)
			{
				int pivot = Partition(arr,start,end);
				QuickSort(arr,start,pivot-1);
				QuickSort(arr,pivot+1,end);
			}
		}

		static int Partition(int[] arr,int low,int heigh)
		{
			int pivot = arr[heigh]; //pivot value

			int index = low;//tracking index

			for(int i = low; i < heigh; i++)
			{
				if (arr[i] < pivot)
				{
					swap(arr, i, index);
					index++;
				}
			}

			swap(arr, index, heigh);
			return index;
		}

		static void swap(int[] arr, int i,int j)
		{
			int temp = arr[j];
			arr[j] = arr[i];
			arr[i] = temp;
		}
	}
}
