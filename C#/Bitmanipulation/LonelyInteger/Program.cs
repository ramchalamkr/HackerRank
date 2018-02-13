using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;

class Solution
{

	static int Lonelyinteger(int[] a)
	{
		int res = 0;
		foreach(int i in a)
		{
			res ^= i;
		}
		return res;
	}

	static void Main(String[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] a_temp = Console.ReadLine().Split(' ');
		int[] a = Array.ConvertAll(a_temp, Int32.Parse);
		int result = Lonelyinteger(a);
		Console.WriteLine(result);
	}
}
