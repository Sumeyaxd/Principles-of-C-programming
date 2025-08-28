int n = int.Parse(Console.ReadLine()!);

int min = Int32.MaxValue;  
int max = Int32.MinValue;  

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine()!);

    if (number < min)
    {
        min = number;
    }

    if (number > max)
    {
        max = number;
    }
}

Console.WriteLine($"Min = {min}");
Console.WriteLine($"Max = {max}");