// Программа проверяет пятизначное число на палиндромом    //01234 i
                                                           //12321
bool palindrom (int a)
{
    if (a < 10000 || a > 99999)
    {
        Console.WriteLine("Число не пятизначное");
    }
    string number = Convert.ToString(a);
    return (number[0] == number[4]) && (number[1] == number[3]);
    
}
Console.WriteLine($"{(palindrom(12321) ? "Число палиндром" : "Число не палиндром")}");