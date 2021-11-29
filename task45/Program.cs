// Показать числа Фибоначчи

Console.WriteLine ("На каком числе вы хотите остановиться? Введите его:");
int number = Convert.ToInt32(Console.ReadLine());

int firstNumber = 1;
int secondNumber = 1;
Console.Write("{0}", firstNumber + " ");
Console.Write("{0}", secondNumber + " ");

int summa = 0;
while (number >= summa)
{
    summa = firstNumber + secondNumber;
    Console.Write("{0}", summa + " ");
    firstNumber = secondNumber;
    secondNumber = summa;
}