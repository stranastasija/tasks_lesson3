// Написать программу преобразования десятичного числа в двоичное

string programm (int a)
{
    string number = string.Empty;

    while (a!=0)
    {
        if (a%2==0)
        {
            number +=$"{0}";
        }
        else
        {
            number +=$"{1}";
        }

        a = a/2;
    }

    return number;
}

Console.WriteLine(programm(69));