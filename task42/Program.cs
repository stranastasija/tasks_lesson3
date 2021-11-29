// Определить сколько чисел больше 0 введено с клавиатуры

Console.WriteLine("Введите любое количество цифр через пробел");
string Number = Console.ReadLine ();
Console.WriteLine ("Вы ввели следующие числа:");
Console.Write (Number + " ");

int chislo = Convert.ToInt32(Number);

int kolichestvo = 0;

while (chislo > 0)
{
    kolichestvo = kolichestvo + 1;
}
Console.WriteLine("Вы ввели " + kolichestvo + " количество чисел больше нуля");