using System;
using System.Numerics;

int n = int.Parse(Console.ReadLine()!);   // n ≥ 0


BigInteger catalan = 1; // C0 = 1
for (int k = 1; k <= n; k++)
{
    catalan = catalan * (4*k - 2) / (k + 1);
}

Console.WriteLine(catalan);