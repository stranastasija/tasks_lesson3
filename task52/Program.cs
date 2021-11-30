//  В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void Print(int [,] mass)
{

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write($"{mass[i, j]} ");
        }
        Console.WriteLine();
    }

}

void Fill (int [,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass [i,j] = new Random().Next (0, 100);
        }
    
    }
}

int [,] Zamena (int [,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    { 
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                mass [i, j] = i*i;
                mass [i, j] = j*j;
                
            }
        }
    }
    return mass;
}


int [,] matr = new int [4, 3];
Print (matr);
Console.WriteLine();
Fill (matr);
Print (matr);
Console.WriteLine();
Zamena(matr);
Print(Zamena(matr)); // идет перезаполнение... выводит не квадраты, а единицы