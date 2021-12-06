// Определить сколько чисел больше 0 введено с клавиатуры

Console.WriteLine("Введите любое количество цифр через пробел");
int Number = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Вы ввели следующие числа:");
Console.Write (Number + " ");

//int chislo = Convert.ToInt32(Number);

int kolichestvo = 0;

while (Number > 0)
{
    kolichestvo = kolichestvo + 1;
}
Console.WriteLine("Вы ввели " + kolichestvo + " количество чисел больше нуля");