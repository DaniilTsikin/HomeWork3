// Найти расстояние между точками в пространстве 2D/3D

double Distance2D(double x1, double y1, double x2, double y2 )
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return result;
}
double Distance3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}
Console.Write("В каком пространстве находить расстояние между двумя точками?(2D/3D): ");
string choice = Console.ReadLine();

if (choice == "2D")
{
    Console.Write("Введите точку x1: ");
    double x1 = double.Parse(Console.ReadLine());
    Console.Write("Введите точку y1: ");
    double y1 = double.Parse(Console.ReadLine());
    Console.Write("Введите точку x2: ");
    double x2 = double.Parse(Console.ReadLine());
    Console.Write("Введите точку y2: ");
    double y2 = double.Parse(Console.ReadLine());
    Console.Write("Расстояние между точками " + Distance2D(x1, y1, x2, y2));
}
else if (choice == "3D")
{
    Console.Write("Введите точку x1: ");
    double x1 = double.Parse(Console.ReadLine());
    Console.Write("Введите точку y1: ");
    double y1 = double.Parse(Console.ReadLine());
    Console.Write("Введите точку z1: ");
    double z1 = double.Parse(Console.ReadLine());
    Console.Write("Введите точку x2: ");
    double x2 = double.Parse(Console.ReadLine());
    Console.Write("Введите точку y2: ");
    double y2 = double.Parse(Console.ReadLine());
    Console.Write("Введите точку z2: ");
    double z2 = double.Parse(Console.ReadLine());
    Console.Write("Расстояние между точками " + Distance3D(x1, y1, z1, x2, y2, z2));
}
else
{
    Console.Write("Введён не корректный запрос: ");
}
