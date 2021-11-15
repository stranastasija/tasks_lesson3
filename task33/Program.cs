// Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива

int element (int lenght)
{
    int [] A = new int [lenght];
    int index = 0;

    while (index < lenght)
    {
        A [index] = new Random().Next(0, 9); 
        index++;
    }

    index = 0;
    while (index < lenght)
    {
        int array = A[index];
        Console.Write(array + " ");
        index++;
    }
    Console.WriteLine(" ");

    int sum = 0;
    for (int i=0; i< lenght; i++)
    {
        sum +=A[i];
    }
    Console.WriteLine(sum);
}
Console.WriteLine(element(12));    