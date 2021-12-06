// Показать натуральные числа от 1 до N, N задано

string Number (int n)
{
    int m = 1;
    if (m == n) return $"{n}";
    return (m > n) ? Number (n+1) + " " + n:
    Number (n-1) + " " + n;
}
Console.WriteLine(Number(16));