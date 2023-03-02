// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты X первой точки");
int numberX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y первой точки");
int numberY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z первой точки");
int numberZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X второй точки");
int numberX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y второй точки");
int numberY2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z второй точки");
int numberZ2 = Convert.ToInt32(Console.ReadLine());

double Distance(int xOne, int yOne, int zOne, int xTwo, int yTwo, int zTwo)
{
    int x = xOne - xTwo;
    int y = yOne - yTwo;
    int z = zOne - zTwo;
    double dist = Math.Sqrt(x * x + y * y + z * z);
    return dist;
}
double result = Distance(numberX, numberY, numberZ, numberX2, numberY2, numberZ2);
result = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(result);
