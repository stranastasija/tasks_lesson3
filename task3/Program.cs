// Даны два числа. Показать большее и меньшее.

double numberA = new Random().Next(0, 100);
Console.WriteLine(numberA);
double numberB = new Random().Next(0, 100);
Console.WriteLine(numberB);

if (numberA < numberB)
{
    Console.WriteLine(numberB + " - больше, " + numberA + " - меньше");
}
if (numberA > numberB)
{
    Console.WriteLine(numberA + " - больше, " + numberB + " - меньше");
}
if (numberA == numberB)
{
    Console.WriteLine("Числа равны");
}