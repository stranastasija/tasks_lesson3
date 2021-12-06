// Написать программу показывающие первые N чисел, 
//для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем

int a = 1;
int b = 1;
Console.WriteLine(a);
Console.WriteLine(b);
int res = 0;
int count = 0;
void Fib (int n)
{
    if (count < n) Fib (n-1);
    res = a+b;
    a=b;
    b = res;
    Console.WriteLine($"{res}");
}
Fib(4);