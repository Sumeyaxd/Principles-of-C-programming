int n = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= n; i++)
{
    // проверка: "не се делят едновременно на 3 и 7" 
    // т.е. не делими на 21
    if (i % 21 != 0)
    {
        Console.WriteLine(i);
    }
}
