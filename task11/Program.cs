// Показать вторую цифру трехзначного числа

int second (int a)
{
    if (a < 100 || a > 1000)
    {
        Console.WriteLine("Число не трехзначное");
        
    }
    int N = 0;
    N = a/10;

    return (N%10);
}
Console.WriteLine(second (932));