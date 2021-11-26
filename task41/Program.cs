// Выяснить являются ли три числа сторонами треугольника 

int firstNumber = -5;
int secondNumber = 20;
int thirdNhumber = 18;

bool tr = ((firstNumber + secondNumber > thirdNhumber) && (firstNumber + thirdNhumber > secondNumber) && (secondNumber + thirdNhumber > firstNumber));

if (tr)
{
    Console.WriteLine("Являются");
}
else 
{
    Console.WriteLine("Не являются");
}

bool number (int firstNumber, int secondNumber, int thirdNhumber)
{
    if ((firstNumber + secondNumber > thirdNhumber) && (firstNumber + thirdNhumber > secondNumber) && (secondNumber + thirdNhumber > firstNumber))
    {
        Console.WriteLine("Являются");
        return true;
    }
    else 
    {
        Console.WriteLine("Не являются");
        return false;
    }
}

Console.WriteLine(number(1,92,69));