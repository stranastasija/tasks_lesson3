// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

//Console.WriteLine ("Введите число от 10 до 99");
//string N = Console.ReadLine();

//if (N[0]>N[1])
//{
//    Console.WriteLine(N[0]);
//}
//else
//{
//    Console.WriteLine(N[1]);
//}

int number = new Random().Next(10, 100);
Console.WriteLine(number);

char max (int number)
{
    string N = Convert.ToString(number);
    char first = N[0];
    char second = N[1];
    if (first > second) return first;
    else return second;
}
char result = max(number);
Console.WriteLine(result);