// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить

int [,] matrix (int [,] arr)
{
    int [,] mat = new int [arr.GetLength(1), arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int a = i;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            int b = j;
            mat [a, b] = arr [j, i];
        }
    }
    return mat;
}

int [,] mat = new int [2,3];
matrix(mat);