// Дано число. Проверить кратно ли оно 7 и 23 

bool number (int a)
{
    return (a%7==0) && (a%23==0);
}
Console.WriteLine (number(161));
