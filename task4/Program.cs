// По заданному номеру дня недели вывести его название.

//string day = Console.ReadLine("Введите номер дня недели");

Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
{
    Console.WriteLine("Monday");
    return;
}
if (day == 2)
{
    Console.WriteLine("Tuesday");
    return;
}
if (day == 3)
{
    Console.WriteLine("Wednesday");
    return;
}
if (day == 4)
{
    Console.WriteLine("Thursday");
    return;
}
if (day == 5)
{
    Console.WriteLine("Friday");
    return;
}
if (day == 6)
{
    Console.WriteLine("Saturday");
    return;
}
if (day == 7)
{
    Console.WriteLine("Sunday");
    return;
}


if (day < 8)
{
    Console.WriteLine("Такого дня недели не существует");
    return;
}
if (day > 0)
{
    Console.WriteLine("Такого дня недели не существует");
    return;
}