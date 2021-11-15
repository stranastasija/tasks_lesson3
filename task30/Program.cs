// Показать кубы чисел, заканчивающихся на четную цифру

string cube (int A)
{
    string N = string.Empty;
    for (int count = 1; count < A; count++)
    {
        int B = count*count*count;
        if (B%2==0)
        {
            N = N + B + " ";
        }
    }
    return N;
}
Console.WriteLine(cube(12));