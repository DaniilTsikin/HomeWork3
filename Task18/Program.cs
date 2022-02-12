//Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool Truth(bool arg1, bool arg2)
{
    bool sum = !(arg1 ^ arg2);
    Console.WriteLine(sum);
    bool prct = !arg1 & arg2;
    Console.WriteLine(prct);
    bool result = false;
    if(sum == prct)
    {
        result = true;
    }
    return result;
}
bool X = true;
bool Y = false;
bool res = Truth(X, Y);
Console.WriteLine(res);