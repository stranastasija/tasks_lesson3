// Выяснить, кратно ли число заданному, если нет, вывести остаток
// Заданное = 7


double N = new Random().Next(0, 1000);
Console.Write(N);

double ost = N%7;
if (ost == 0)
{
    Console.WriteLine(" - число кратно 7");
}
else 
{
    Console.WriteLine(" - число не кратно 7, остаток = " + ost);
}