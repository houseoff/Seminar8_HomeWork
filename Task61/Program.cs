// Задача 61. Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
long Factorial(int n)
{
    if (n < 2)
        return 1;
    return n * Factorial(n - 1);
}

long Combinations(int k, int n)
{
    return Factorial(n) / (Factorial(k) * Factorial(n - k));
}

void PascalsTriangle (int n)
{
    long c = 0;
    for (int i = 0; i <= n; i++)
    {
        for (int k = 0; k < n - i; k++)
            Console.Write("   ");

        for (int j = 0; j <= i; j++)
        {
            c = Combinations(j, i);
            if (c < 10)
                Console.Write("    {0} ", c);
            else if (c < 100)
                Console.Write("   {0} ", c);
            else if (c < 1000)
                Console.Write("  {0} ", c);
            else
                Console.Write(" {0} ", c);
        }
        Console.WriteLine();
    }
}

Console.Clear();
int n = new Random().Next(0, 11);
Console.WriteLine($"Число N: {n}");
Console.WriteLine("Треугольник Паскаля");
PascalsTriangle(n);