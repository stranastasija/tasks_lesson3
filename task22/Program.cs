// Удалить вторую цифру трёхзначного числа 389


    int N= new Random().Next(0,1000);
    
    Console.Write(N);

        if (N < 100 || N > 999)
        {
            Console.WriteLine(" - число не трехзначное");
        }
        else
        {
            string a = Convert.ToString(N/100);
            string b = Convert.ToString(N%10);    
            Console.WriteLine(" " + a + b);
        }

