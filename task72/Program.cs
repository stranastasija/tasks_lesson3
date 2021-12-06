// Написать программу возведения числа А в целую стень B

int Count = 0;
int res = 1;
int Pow (int A, int B)
{
    if (B == 0) return 1;
    if (Count < B) Pow (A, B-1);
    res *= A;
    return res;
}

Console.WriteLine(Pow(3,3));