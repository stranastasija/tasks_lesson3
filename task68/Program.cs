// Показать натуральные числа от M до N, N и M заданы

string Number (int m, int n)
{
    if (m == n) return $"{n}";
    return (m > n) ? Number (m, n+1) + " " + n:
    Number (m, n-1) + " " + n;
}
Console.WriteLine(Number(20,10));