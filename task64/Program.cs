// Показать треугольник Паскаля

static int Tr (int n)
{
    int [] a = new int [n];
    a[0] = 1;
    for (int i=1; i<n; i++)
    {
        int left = 0;
        for (int j = 0; j <=i; j++)
        {
            int treu = a [j];
            a [j] += left;
            left = treu;
        }
    }
    return a;
}
Console.WriteLine(Tr(10));