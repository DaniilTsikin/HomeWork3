//  Найти кубы чисел от 1 до N
Console.Write("Введите любое число от 1 и больше: ");
int input = int.Parse(Console.ReadLine());

for (int n = 1; n <= input; n++)
{
    Console.Write($"{n*n*n} ");
}

