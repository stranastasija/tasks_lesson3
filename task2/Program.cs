// По двум заданным числам проверять является ли первое квадратом второго.

double numberA = 25; //new Random().Next(0, 100);
Console.WriteLine(numberA);
double numberB = 5; //new Random().Next(0, 100);
Console.WriteLine(numberB);
//При рандоме вероятность попасть в квадрат очень мала.
if (numberA == numberB*numberB)
{
    Console.WriteLine(numberA + " - квадрат " + numberB);
}
if (numberA != numberB*numberB)
{
    Console.WriteLine("Числа не связаны");
}