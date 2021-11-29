// Показать двумерный массив размером m×n заполненный вещественными числами

void Print(double [,] mass)
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

void Fill (double [,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass [i,j] = new Random().Next (-10, 10);
        }
    
    }
}

double [,] massiv = new double [3, 6];
//Print(massiv);
//Console.WriteLine();
Fill(massiv);
Print(massiv);