/* package whatever; // don't place package name! */

import java.util.*;
import java.lang.*;
import java.io.*;
import java.math.BigInteger;

/* Name of the class has to be "Main" only if the class is public. */
class Ideone
{
	static long f[] = new long[10005];
	static long mod = 100000007;
	
	public static void main (String[] args) throws java.lang.Exception
	{
		Scanner s = new Scanner(System.in);
		calculate();
		int t = s.nextInt();
		int n;
		for (int c = 1; c <= t; ++c) {
			n = s.nextInt();
			System.out.println("Case " + c + ": " + f[n]);
		}
	}
	
	private static void calculate()
    	{
	    f[0] = 1;
	    for (int i = 1; i < 10005; ++i)
	    	f[i] = (f[i - 1] * i) % mod;
    	}
	
}
