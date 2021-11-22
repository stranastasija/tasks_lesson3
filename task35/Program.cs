// Определить, присутствует ли в заданном массиве, некоторое число

int [] sozdanie (int length)
{
    int [] mass = new int [length];
    return mass;
}

int [] zapolnenie (int [] mass, int min, int max)
{
    int i = 0;
    while (i < mass.Length)
    {
        mass [i] = new Random().Next(min, max+1);
        i++;
    }
    return mass;
}

string print (int [] mass)
{
    string res = String.Empty;
    int i = 0;
    while (i < mass.Length)
    {
        int arr = mass [i];
        Console.Write(arr + " ");
        i++;
    }
    return res;
}

void search (int [] mass)
{
    int i = 0;
    while (i < mass.Length)
    {
        Console.WriteLine("Введите число, которое необходимо найти в массиве:");
        string element = Console.ReadLine ();
        int intVal = Convert.ToInt32(element);
        if (mass[i]==intVal)
        {
        Console.WriteLine (intVal + " - число есть в массиве");
        i++;
        break;
        }
        else
        {
        Console.WriteLine(intVal + " - такого числа в массиве нет");
        break;
        }
    }
}

Console.WriteLine("Введите количество элементов для создания массива");
string element = Console.ReadLine();
int massiv = Convert.ToInt32 (element);
int [] mas = sozdanie (massiv);
Console.WriteLine("Введите минимальный порог для создания массива");
string A = Console.ReadLine();
int a = Convert.ToInt32 (A);
Console.WriteLine("Введите максимальный порог для создания массива");
string B = Console.ReadLine();
int b = Convert.ToInt32 (B);
Console.WriteLine("Массив: ");
zapolnenie(mas, a, b);
print (mas);
Console.WriteLine("");
search (mas);