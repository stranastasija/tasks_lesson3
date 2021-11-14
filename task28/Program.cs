// Подсчитать сумму цифр в числе

int sum (int a)
{
    int result = 0;
    while (a > 0)
    {
        result += a % 10;
        a = a/10;
    }
    return result;
}
Console.WriteLine (sum (12395));