//  В двумерном массиве n×k заменить четные элементы на противоположные

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

void Zamena(double [,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (mass[i,j] %2 == 0) 
            {
                Console.Write($"{mass [i,j] * (-1)} ");
            }
            else
            {
                Console.Write($"{mass [i,j]} ");
            }
        }
        
    }
}


double [,] massiv = new double [2, 4];

Fill(massiv);
Print(massiv);
Console.WriteLine();
Zamena(massiv);
Print(massiv);