// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine ("Введите число от 10 до 99");
string N = Console.ReadLine();

if (N[0]>N[1])
{
    Console.WriteLine(N[0]);
}
else
{
    Console.WriteLine(N[1]);
}