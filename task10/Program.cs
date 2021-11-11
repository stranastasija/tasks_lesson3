// Показать последнюю цифру трехзначного числа

int tree (int a)
{
    if (a < 100 || a > 1000)
    {
        Console.WriteLine("Число не трехзначное");
    }
    
    return (a%10);
}
Console.WriteLine(tree (367));