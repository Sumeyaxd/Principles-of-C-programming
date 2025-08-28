int n = int.Parse(Console.ReadLine()!);

int min = Int32.MaxValue;
int max = Int32.MinValue;

for (int i = 0; i < n; i++)
{
    int current = int.Parse(Console.ReadLine()!);

    if (current < min)
    {
        min = current;
    }

    if (current > max)
    {
        max = current;
    }
}

Console.WriteLine($"Min = {min}");
Console.WriteLine($"Max = {max}");
