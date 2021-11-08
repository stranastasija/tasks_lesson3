// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите цифру от 1 до 4, чтобы узнать диапозон четверти окружности");
int number = int.Parse(Console.ReadLine());

switch (number)
{
    case 1 : Console.WriteLine("Х от 0 до +бесконечности, У от 0 до +бесконечности"); break;
    case 2 : Console.WriteLine("Х от -бесконечности до 0, У от 0 до +бесконечности"); break;
    case 3 : Console.WriteLine("Х от -бесконечности до 0, У от -бесконечности до 0"); break;
    case 4 : Console.WriteLine("Х от 0 до +бесконечности, У от -бесконечности до 0"); break;
    default : Console.WriteLine(" - не входит в систему координат"); break;
}
