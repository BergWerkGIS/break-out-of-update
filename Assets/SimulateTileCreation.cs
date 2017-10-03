using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SimulateTileCreation {


	public static int NthFibonacciNumber(int n)
	{
		if ((n == 0) || (n == 1))
		{
			return n;
		}
		else
		{
			return (NthFibonacciNumber(n - 1) + NthFibonacciNumber(n - 2));
		}
	}


}
