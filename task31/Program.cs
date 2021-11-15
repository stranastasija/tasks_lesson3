// Задать массив из 8 элементов и вывести их на экран 

int [] A = new int [8];
int index = 0;

while (index < 8)
{
    A [index] = new Random().Next(-100, 100);
    index++;
}

index = 0;
while (index < 8)
{
    int array = A[index];
    Console.Write(array + " ");
    index++;
}
