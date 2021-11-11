// Найти максимальное из трех чисел

int max (int a, int b, int c)
{
    int max = a;
    return (a > b && a > c) ? max = a : ((b > a && b > c) ? max = b : max = c);
}
Console.WriteLine(max(2, 5, 10));