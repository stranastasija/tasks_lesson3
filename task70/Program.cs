// Найти сумму цифр числа

int sum = 0;
int SummaNumber (int number)
{
    if (number == 0) return sum;
    else
    {
        sum += number % 10;
        number = SummaNumber(number / 10);
    }
    return sum;
}

Console.WriteLine (SummaNumber(492));