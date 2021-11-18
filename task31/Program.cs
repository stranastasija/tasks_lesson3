// Задать массив из 8 элементов и вывести их на экран 

int [] mas (int length)
{
    int [] B = new int [length];
    return B;
}

int [] zapolnenie (int [] C, int min, int max)
{
    int index = 0;

    while (index < C.Length)
    {
    C [index] = new Random().Next(min, max);
    index++;
    }
    return C;
}


void print (int [] massiv)
{
    Console.WriteLine("");
    int index = 0;
    while (index < massiv.Length)
    {
    int array = massiv[index];
    Console.Write(array + " ");
    index++;
    }
    
}


int [] massiv2 = mas (12); //создание массива из метода (8 элементов)
massiv2 = zapolnenie ( massiv2, 0, 10); // заполнение созданного элемента (название, от, до)
int index = 1;
while (index <= 1)
{
    print (massiv2); // печать массива 5 раз
    index++;
}

//печать один раз, если больше не понадобится
//print (mas(8) );
