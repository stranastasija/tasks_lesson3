// Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

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
        if (min < 100 || max > 999)
        {
            Console.WriteLine("Числа должны быть трехзначные");
            break;
        }
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

void number (int [] mas)
{
    int firstsum = 0;
    int secondsum = 0;

    for (int i = 0; i<=mas.Length; i++)
    {

        if (mas [i] %2 ==0)
        { 
            int numbers = mas [i];
            Console.WriteLine(numbers + " - число четное");
            
        }
    firstsum = firstsum + i;
    Console.WriteLine(firstsum + " четных чисел");    
  
        if (mas [i] %2 !=0)
        {
            int numbers = mas [i];
            Console.WriteLine(numbers + " - число нечетное");
            
        }
    secondsum = secondsum + i;
    Console.WriteLine(secondsum + " нечетных чисел");
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
number (mas);

