// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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

int [,] Search (int [,] mass)
{
    Console.WriteLine("Введите число, которое вы хотите найти в данном массиве:");
    string user = Console.ReadLine();
    int userNumber = Convert.ToInt32(user);
//    int summa = 0;

    for (int i = 0; i < mass.GetLength(0); i++)
    { 
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (mass[i,j] == userNumber)
            {
                //summa++;
                Console.WriteLine("Число совпало с числом в матрице.");
                //break;
            }
            else 
            {
                Console.WriteLine("Число не совпадает с числом в матрице.");
                //break;
            }
        }
    }
    return mass;
}


int [,] matr = new int [3, 3];

Fill (matr);
Print (matr);
Console.WriteLine();
Search(matr);
 