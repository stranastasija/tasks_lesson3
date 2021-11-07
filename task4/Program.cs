// По заданному номеру дня недели вывести его название.

//string day = Console.ReadLine("Введите номер дня недели");

int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер дня недели");

if (day ==1)
{
    Console.WriteLine("Monday");
}
if (day ==2)
{
    Console.WriteLine("Tuesday");
}
if (day ==3)
{
    Console.WriteLine("Wednesday");
}
if (day ==4)
{
    Console.WriteLine("Thursday");
}
if (day ==5)
{
    Console.WriteLine("Friday");
}
if (day ==6)
{
    Console.WriteLine("Saturday");
}
if (day ==7)
{
    Console.WriteLine("Sunday");
}