// Задать двумерный массив следующим правилом: Aₘₙ = m+n

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
            mass [i,j] = i+j;
        }
    
    }
}

double [,] matrix = new double [4, 3];
Print (matrix);
Console.WriteLine();
Fill (matrix);
Print(matrix);
