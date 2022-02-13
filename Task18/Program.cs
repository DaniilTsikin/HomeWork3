//Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool Truth(bool arg1, bool arg2)
{
    bool sum = !(arg1 ^ arg2);
    Console.WriteLine($"Результат сложения: {sum}");
    bool prct = !arg1 && !arg2;
    Console.WriteLine($"Результат произведения: {prct}");
    bool result = false;
    if(sum == prct)
    {
        result = true;
    }
    return result;
}
bool X = false;
bool Y = true;
bool res = Truth(X, Y);
Console.WriteLine(res);
X = true;
Y = false;
Console.WriteLine(res);
X = true;
Y = true;
Console.WriteLine(res);
X = false;
Y = false;
Console.WriteLine(res);
