// Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива

int [] element (int length)
{
    int [] mas = new int [length];
    return mas;
}

int [] sozdanie (int [] massiv, int min, int max)
{
    int index = 0;
    while (index < massiv.Length)
    {
        massiv [index] = new Random().Next(min, max +1); 
        index++;
    }
    return massiv;
}

string print (int [] arr)
{
    string res = String.Empty;
    int index = 0;
    while (index < arr.Length)
    {
        int array = arr[index];
        Console.Write(array + " ");
        index++;
    }
    return res;
}


string summa (int [] array)
{
    string res = String.Empty;
    int sum = 0;
    for (int i=0; i< array.Length; i++)
    {
        sum +=array[i];
    }
    return res;
}


int [] A = element(12);    
sozdanie(A, 0, 9);
print (A);
File.WriteAllText("file.txt", print (A));
summa (A);