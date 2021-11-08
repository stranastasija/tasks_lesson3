// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y 

bool text (bool X, bool Y)
{
    return (!(X || Y) == (!X && !Y));
}
Console.WriteLine(text(true, true));
Console.WriteLine(text(true, false));
Console.WriteLine(text(false, true));
Console.WriteLine(text(false, false));
//Показываем, что все варианты дают истину.