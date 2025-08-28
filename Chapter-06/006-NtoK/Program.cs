int n = int.Parse(Console.ReadLine()!);
int k = int.Parse(Console.ReadLine()!);

long result = 1;

for (int i = k + 1; i <= n; i++)
{
    result *= i;
}

Console.WriteLine(result);
