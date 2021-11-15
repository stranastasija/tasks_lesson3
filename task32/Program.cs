// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

int [] A = new int [8];
int index = 0;

while (index < 8)
{
    A [index] = new Random().Next(-1, 2); //если поставить (-1, 1), то выводит только -1, 0
    index++;
}

index = 0;
while (index < 8)
{
    int array = A[index];
    Console.Write(array + " ");
    index++;
}