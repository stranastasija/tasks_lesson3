// Найти сумму чисел от 1 до А

long sum (int N)
{
    long summa = 0;
    for (int i = 0; i<= N; i++)
    {
        summa = summa + i;
    }
    return summa;
}

DateTime DT = DateTime.Now;
Console.WriteLine(sum(1_000_000));
System.Console.WriteLine((DateTime.Now - DT).TotalMilliseconds);

long summa (int N)
{
    return ((1 + N) * N) / 2;
}
DateTime DTProg = DateTime.Now;
Console.WriteLine(summa(1_000_000));
System.Console.WriteLine((DateTime.Now - DTProg).TotalMilliseconds);