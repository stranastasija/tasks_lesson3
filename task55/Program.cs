// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов

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
            mass [i,j] = new Random().Next (0, 10);
        }
    
    }
}

void Summa (double [,] mass)
{
    double sum1 = 0;
    double sum2 = 0;
    double sum3 = 0;
    double srAr1 = 0;
    double srAr2 = 0;
    double srAr3 = 0;

    for (int i = 0; i < mass.GetLength(0); i++)
    { 
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            sum1= mass[0,0]+mass[1,0]+mass[2,0]; 
            srAr1 = sum1/mass.GetLength(0);  
            Console.WriteLine("1 столбец: " + srAr1);
            
            sum2= mass[0,1]+mass[1,1]+mass[2,1]; 
            srAr2 = sum2/mass.GetLength(0);  
            Console.WriteLine("2 столбец: " + srAr2);
            
            sum3= mass[0,2]+mass[1,2]+mass[2,2]; 
            srAr3 = sum3/mass.GetLength(0);  
            Console.WriteLine("3 столбец: " + srAr3);
            break;
        }
        break; 
    }
}


double [,] matr = new double [3, 3];

Fill (matr);
Print (matr);
Console.WriteLine();
Summa(matr);
 