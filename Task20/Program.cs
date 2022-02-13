// Задать номер четверти, показать диапазоны для возможных координат

int CheckQuarter()
{
   int result = 0; 
   bool isError = true;
   while (isError)
   {
       Console.Write("Введите номер четверти от 1 до 4: ");
       string input = Console.ReadLine();
       int.TryParse(input, out result);
       isError = result < 1 || result > 4;
   }
    return result;
}
void GetRange(int number)
{
    
    int[] X = {0, 0, 0};
    int[] Y = {0, 0, 0};
    if (number == 1)
    {
        Console.WriteLine("X может быть в диапазоне от 1 и больше");
        Console.WriteLine($"Например: {X[0] = 1}, {X[1] = 2}, {X[2] = 3}");
        Console.WriteLine("Y может быть в диапазоне от 1 и больше");
        Console.WriteLine($"Например: {Y[0] = 1}, {Y[1] = 2}, {Y[2] = 3}");
    }
    else if (number == 2)
    {
        Console.WriteLine("X может быть в диапазоне от -1 и меньше");
        Console.WriteLine($"Например: {X[0] = -1}, {X[1] = -2}, {X[2] = -3}");
        Console.WriteLine("Y может быть в диапазоне от 1 и больше");
        Console.WriteLine($"Например: {Y[0] = 1}, {Y[1] = 2}, {Y[2] = 3}");
    }
    else if (number == 3)
    {
        Console.WriteLine("X может быть в диапазоне от -1 и меньше");
        Console.WriteLine($"Например: {X[0] = -1}, {X[1] = -2}, {X[2] = -3}");
        Console.WriteLine("Y может быть в диапазоне от -1 и меньше");
        Console.WriteLine($"Например: {Y[0] = -1}, {Y[1] = -2}, {Y[2] = -3}");
    }
    else if (number == 4)
    {
        Console.WriteLine("X может быть в диапазоне от 1 и больше");
        Console.WriteLine($"Например: {X[0] = 1}, {X[1] = 2}, {X[2] = 3}");
        Console.WriteLine("Y может быть в диапазоне от -1 и меньше");
        Console.WriteLine($"Например: {Y[0] = -1}, {Y[1] = -2}, {Y[2] = -3}");
    }
}

int quarter = CheckQuarter();
Console.WriteLine(quarter);
GetRange(quarter);



