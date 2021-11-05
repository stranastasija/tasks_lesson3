// Вывести квадрат числа

double number = new Random().Next(0, 100);
//Возникла проблема с тем, что изначально писала код, где число вводил пользователь. 
//Но нигде не могу найти, как преобразовать string в int/double. 
//Так что этот вариант пока в работе.

Console.WriteLine(number);
double result = number * number;
Console.Write("Квадрат числа = ");
Console.WriteLine(result);