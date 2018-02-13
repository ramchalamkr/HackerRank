using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
	static void Main(String[] args)
	{
		int t = Convert.ToInt32(Console.ReadLine());
		for (int a0 = 0; a0 < t;a0++)
		{
			UInt64 n = Convert.ToUInt64(Console.ReadLine());
			int loopCounter = 0;
			n = n - 1;
			while(n!=0)
			{
				n &= n - 1;
				loopCounter++;
			}
			//Console.WriteLine(loopCounter);
			if (loopCounter % 2 == 0)
				Console.WriteLine("Richard");
			else
				Console.WriteLine("Louise");
		}
	}
}