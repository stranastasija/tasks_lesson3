// Выяснить, является ли число четным

bool number (int a)
{
    string number = Convert.ToString(a);
    return (a %2==0);
}
Console.WriteLine($"{(number(9) ? " число четное" : " число нечетное")}");