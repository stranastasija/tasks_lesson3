// Написать программу копирования массива

namespace Copy 
{
    class Programm
    {
        static void Main (string [] args)
        {
            int a = int.Parse(Console.ReadLine());
            int [] array = new int [a];
            for (int i = 0; i < array.Length; i++)
            {
                array [i] = int.Parse(Console.ReadLine());

            }
            int [] array1 = (int []) array.Clone();
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.ReadKey();
        }
    }
}