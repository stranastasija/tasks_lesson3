// Показать двумерный массив размером m×n заполненный целыми числами


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
            mass [i,j] = new Random().Next (1, 10);
        }
    
    }
}

int [,] massiv = new int [3, 6];
Print(massiv);
Console.WriteLine();
Fill(massiv);
Print(massiv);