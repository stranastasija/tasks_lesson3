// Написать программу замену элементов массива на противоположные

int [] sozdanie (int length)
{
    int [] massiv = new int [length];
    return massiv;
}

int [] zapolnenie (int [] massiv, int min, int max)
{
    int index = 0;
    while (index < massiv.Length)
    {
        massiv [index] = new Random ().Next (min, max +1);
        index++;
    }
    return massiv;
}

string print (int [] massiv)
{
    string res = String.Empty;
    int index = 0;
    while (index < massiv.Length)
    {
        int array = massiv [index];
        Console.Write (array + " ");
        index++;
    }
    return res;
}

string zamena (int [] massiv)
{
    string res = String.Empty;
    int index = 0;
    while (index < massiv.Length)
    {
        int arr = massiv [index] * (-1);
        Console.Write (arr + " ");
        index++;
    }
    return res;
}

int [] A = sozdanie(12);
zapolnenie(A, -10, 10);
print (A);
Console.WriteLine("");
zamena (A);