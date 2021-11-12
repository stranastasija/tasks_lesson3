// Найти третью цифру числа или сообщить, что ее нет

// Вывод третьей цифры слева направо

int a = new Random().Next (0, 1000000);

Console.Write(a);
Console.WriteLine(" - заданное число");

if (a<=99)
{
    Console.WriteLine("Третьей цифры нет");
}

string i = Convert.ToString(a);

Console.Write(i[2]);
Console.WriteLine(" - третья цифра");