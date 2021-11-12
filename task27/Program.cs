// Определить количество цифр в числе

//int col (int n)
//{
//    if (n == 0) return 1;
//
//    int result = 0;
//    while (n != 0) {result++; n /=10; };
//    return result;
//}
//Console.WriteLine(col(4938));

int col (int n)
{
    int result = 1;
    int dev = 10;
    for (int i = 2; i<=n; i++)
    {
        if (n / dev !=0)
        {
            dev = dev * 10;
            result = i;
        }
    }
    return result;
}
Console.WriteLine(col(75209));