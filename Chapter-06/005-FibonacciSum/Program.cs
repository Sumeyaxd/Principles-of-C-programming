int n = int.Parse(Console.ReadLine()!);

// ако потребителят въведе 0 → сумата е 0
if (n <= 0)
{
    Console.WriteLine(0);
    return;
}

// инициализираме първите два члена
int a = 0;
int b = 1;
int sum = 0;

for (int i = 0; i < n; i++)
{
    sum += a; // добавяме текущото число
    int next = a + b; // изчисляваме следващия член
    a = b;
    b = next;
}

Console.WriteLine(sum);

