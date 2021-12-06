// Показать натуральные числа от N до 1, N задано

string Number (int n)
{
    int m = 1;
    if (n == m) return $"{n}";
    return (n > 1) ? Number (n) + " " + (n-1):
    
}
Console.WriteLine(Number(10));