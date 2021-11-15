// Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива

int [] A = new int [12];
int index = 0;

while (index < 12)
{
    A [index] = new Random().Next(0, 9); 
    index++;
}

index = 0;
while (index < 12)
{
    int array = A[index];
    Console.Write(array + " ");
    index++;
}
Console.WriteLine(" ");

int sum = 0;
for (int i=0; i< 12; i++)
{
    sum +=A[i];
}
Console.WriteLine(sum);