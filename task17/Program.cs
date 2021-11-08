// По двум заданным числам проверять является ли одно квадратом другого

bool numbers (int a, int b)
{
    return (a*a==b || b*b==a);
}
Console.WriteLine($"{(numbers(6,4) ? "является" : "не является")}");