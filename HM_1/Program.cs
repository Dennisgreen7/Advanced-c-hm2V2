using System;
using System.Linq;

public static class Combine
{
	public static T[] Combine_arr<T>(this T[] first, T[] second)
	{
		if (first == null)
		{
			return second;
		}
		if (second == null)
		{
			return first;
		}

		return first.Concat(second).ToArray();
	}
}

public class Example
{
	public static void Main()
	{
		int[] arr1 = { 1, 2, 3 };
		int[] arr2 = { 4, 5, 6 };
		string[] arr3 = { "a", "b", "c" };
		string[] arr4 = { "d", "e", "f"};

		int[] combine_arr1 = arr1.Combine_arr<int>(arr2);
		string[] combine_arr2 = arr3.Combine_arr<string>(arr4);
		Console.WriteLine(String.Join(",", combine_arr1));
		Console.WriteLine(String.Join(",", combine_arr2));
		Console.ReadLine();
	}
}