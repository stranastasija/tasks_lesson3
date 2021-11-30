// В матрице чисел найти сумму элементов главной диагонали

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
            mass [i,j] = new Random().Next (0, 10);
        }
    
    }
}

void Summa (int [,] mass)
{
    int sum = 0;

    for (int i = 0; i < mass.GetLength(0); i++)
    { 
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            sum = mass[0,0] + mass[1,1] + mass[2,2];   
            Console.Write(sum + " ");
            break;
        }
        break;
    }
}


int [,] matr = new int [3, 3];

Fill (matr);
Print (matr);
Console.WriteLine();
Summa(matr);
 