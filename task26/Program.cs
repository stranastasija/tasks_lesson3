// Возведите число А в натуральную степень B используя цикл

void number (int A, int B)
{
    string stepen = string.Empty;
    
    int StepenNumber = Convert.ToInt32(stepen);

    while (A != 0) 
    {
        if (B == 0)
        {
            StepenNumber = 1;
        }
        else
        {
            StepenNumber = A ^ B;
        }
    }
    
}
number(2,3);