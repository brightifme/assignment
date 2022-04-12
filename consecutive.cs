
using System;

public class Consecutive
{

	public void printArray(int[] arr, int n)
	{
		for (int i = 0; i < n; ++i)
		{
			Console.Write(" " + arr[i]);
		}
	}
	public void checkConsecutive(int[] arr, int n)
	{
		if (n <= 0)
		{
			return;
		}
		Console.Write("\n Array : ");
		this.printArray(arr, n);
	
		Boolean status = true;
		int min = arr[0];
		int max = arr[0];
		int sum = 0;
	
		for (int i = 1; i < n; ++i)
		{
			if (min > arr[i])
			{
				min = arr[i];
			}
			if (max < arr[i])
			{
				max = arr[i];
			}
			sum += arr[i];
		}
	
		if ((max - min + 1) == n)
		{
	
			Boolean[] auxiliary = new Boolean[n];
		
			for (int i = 0; i < n; ++i)
			{
				auxiliary[i] = false;
			}
		
			for (int i = 0; i < n && status == true; ++i)
			{
				if (auxiliary[arr[i] - min] == true)
				{
					status = false;
				}
				else
				{
					auxiliary[arr[i] - min] = true;
				}
			}
		}
		else
		{
		
			status = false;
		}
		if (status == true)
		{
			Console.Write("\n Yes \n");
		}
		else
		{
			Console.Write("\n No \n");
		}
	}
	public static void Main(String[] args)
	{
		Consecutive task = new Consecutive();
	
		int[] arr1 = {
			4 , -2 , 3 , -1 , 5 , 1 , 0 , 2
		};
		int[] arr2 = {
			1 , 3 , 5 , 4
		};
		int[] arr3 = {
			1 , 4 , 3 , 2 , 1
		};
	
		*/
		int n = arr1.Length;
		task.checkConsecutive(arr1, n);
		
		n = arr2.Length;
		task.checkConsecutive(arr2, n);
	
		n = arr3.Length;
		task.checkConsecutive(arr3, n);
	}
}