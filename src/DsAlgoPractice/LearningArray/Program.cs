namespace LearningArray
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//c# type of single dimensional array declaration
			//A multi-dimensional array in C# is a rectangular array where all dimensions have the same size. It is declared using a single type specifier with multiple comma-separated dimension sizes enclosed in square brackets. 
			//A jagged array in C# is an array whose elements are also arrays. Each element (sub-array) can have a different length, and these sub-arrays can themselves be of different types. It is created by nesting arrays within arrays, where each inner array can have a variable number of elements.

			int[] ages = new int[2];
			ages[0] = 1;
			ages[1] = 2;
		


			int[] ages2 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
			int[] ages3 = [1, 2, 3, 4, 5, 6, 7 ];

			int[,] multiDimensionalArray1 = new int[2, 3];
			multiDimensionalArray1[0, 0] = 1;
			multiDimensionalArray1[0, 1] = 2;
			multiDimensionalArray1[0, 2] = 3;

			multiDimensionalArray1[1, 0] = 4;
			multiDimensionalArray1[1, 1] = 5;
			multiDimensionalArray1[1, 2] = 6;
			int[][] practiceJaggedArray = new int[2][];


			#region first array print
			Console.WriteLine("---------------------------------");
			for (int i = 0; i < ages.Length; i++)
			{
				Console.WriteLine(ages[i]);
			}
			Console.WriteLine("---------------------------------");
			#endregion

			#region second array print
			Console.WriteLine("---------------------------------");
            for (int i = 0; i<ages2.Length; i++)
			{
				Console.WriteLine(ages2[i]);
            }
			Console.WriteLine("---------------------------------");
			#endregion

			#region third array print
			Console.WriteLine("---------------------------------");
			for (int i = 0; i < ages3.Length; i++)
			{
				Console.WriteLine(ages3[i]);
			}
			Console.WriteLine("---------------------------------");
			#endregion

			#region multi dimensional array print
			Console.WriteLine("---------------------------------");
			//for dimension length: arrayname.GetLength(0) =  rows length
			//for dimension length: arrayname.GetLength(0) =  coloumn length
			//total element length: arrayname.Length =  total element

			Console.WriteLine("total element length:"+multiDimensionalArray1.Length);
            Console.WriteLine("total row length:"+multiDimensionalArray1.GetLength(0));
            Console.WriteLine("total coloumn length:"+multiDimensionalArray1.GetLength(1));

            for (int i = 0; i < multiDimensionalArray1.GetLength(0); i++)
			{
				for (int j = 0; j < multiDimensionalArray1.GetLength(1); j++)    
				{
					Console.WriteLine(multiDimensionalArray1[i, j]);
				}
			}
			Console.WriteLine("---------------------------------");
			#endregion

			#region jagged array practice
			Console.WriteLine("---------------------------------");
			Console.WriteLine(practiceJaggedArray.GetLength(0));
			Console.WriteLine(practiceJaggedArray.Length);

			for (int i = 0;i < practiceJaggedArray.GetLength(0); i++)
			{
                Console.Write("enter array size for practiceJaggedArray["+i+"]:");
                int.TryParse(Console.ReadLine(),out int value);
				practiceJaggedArray[i] = new int[value];

				for (int j = 0; j < practiceJaggedArray[i].Length; j++)
				{
					Console.Write("\tenter value for practiceJaggedArray[" + i + "][" + j + "]:");
                    int.TryParse(Console.ReadLine(), out int num);
					practiceJaggedArray[i][j] = num;
				}
			}
			Console.WriteLine("\t\t---------------------------------");
			for (int i = 0; i < practiceJaggedArray.Length; i++)
			{
				for (int j = 0; j < practiceJaggedArray[i].Length; j++)
				{
					Console.WriteLine("\t\t\t\t"+practiceJaggedArray[i][j]);
                }
			}
			Console.WriteLine("\t\t---------------------------------");
			Console.WriteLine("---------------------------------");
			#endregion


			//find out a number form an array
			#region find out a number from array
			Console.WriteLine("---------------------------------");
            Console.Write("enter the value which one you look for:");
			int.TryParse(Console.ReadLine(), out int val);
			bool found = false;

			for (int i = 0; i < ages3.Length; i++)
			{
				if (ages3[i] == val) 
				{
                   found = true; 
				   break;
                }
			}

			if (found)
			{
                Console.WriteLine("found!");
            }else
			{
                Console.WriteLine("not found!");
            }

            Console.WriteLine("---------------------------------");
			#endregion


			#region find out a number from array using binary search
			Console.WriteLine("---------------------------------");
			Console.Write("enter the value which one you look for:");
			int.TryParse(Console.ReadLine(), out int searchingValue);
			bool isFound = false;

			int low = 0, heigh = ages3.Length - 1;
			while (low <= heigh)
			{
				int mid = low + (heigh - low)/2;
                Console.WriteLine("mid:"+mid);

                if (ages3[mid] == searchingValue)
				{
					isFound = true;
					break;
				}

				if (searchingValue < ages3[mid])
				{
					heigh = mid - 1;
				}else
				{
					low = mid + 1;
				}
			}

			

			if (isFound)
			{
				Console.WriteLine("found using binary search!");
			}
			else
			{
				Console.WriteLine("not found using binary search!");
			}

			Console.WriteLine("---------------------------------");
			#endregion

			Console.ReadKey();
		}
	}
}
