// Показать числа от -N до N

int numbers (int N)
{
   int count = -N;
   while (count <= N)
   {
       Console.WriteLine(count);
       count++;
   } 
   return ('N'); //почему выводится 78...
}
Console.Write (numbers(3));