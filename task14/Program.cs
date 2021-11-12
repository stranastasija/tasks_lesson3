// Выяснить, кратно ли число заданному, если нет, вывести остаток
// Заданное = 7


double N = 48;
Console.Write(N);

double ost = N%7;
if (ost == 0)
{
    Console.WriteLine(" - число кратно 7");
}
else 
{
    Console.WriteLine(" - число не кратно, остаток = " + ost);
}