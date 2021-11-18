// Найти расстояние между точками в пространстве 2D/3D

int [] A = {1, 6, 9};
int [] B = {8, 2, 0};

double rasstoyanie (int D, int [] A, int [] B)
{
    double distance = 0;
    if (D == 2)
    {
        distance = Math.Sqrt(Math.Pow((B[0] - A[0]), 2) + Math.Pow((B[1] - A[1]), 2));
    }
    if (D == 3)
    {
        distance = Math.Sqrt(Math.Pow((B[0] - A[0]), 2) + Math.Pow((B[1] - A[1]), 2) + Math.Pow((B[2] - A[2]), 2));
    }
    return distance;
}
double dist = rasstoyanie(2, A, B);
Console.WriteLine (dist);