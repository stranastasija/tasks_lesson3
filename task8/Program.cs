// Показать числа от -N до N

string numbers (int N)
{
   int count = -N;
   while (count <= N)
   {
       Console.WriteLine(count);
       count++;
   } 
   
   return (N);
}
Console.Write (numbers(3));