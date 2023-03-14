// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1: ");
double meaningb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
double meaningk1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double meaningb2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
double meaningk2 = Convert.ToInt32(Console.ReadLine());

void possibleCoincidenceValues(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("Прямые совпадают");
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
        }
    }
}

double SolutionMethod1(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;

}
double SolutionMethod2(double b1, double k1, double b2, double k2)
{

    double y = k1 * (b2 - b1) / (k1 - k2) + b1;
    return y;
}

possibleCoincidenceValues(meaningb1, meaningk1, meaningb2, meaningk2);
double x = SolutionMethod1(meaningb1, meaningk1, meaningb2, meaningk2);
x = Math.Round(x, 2);
double y = SolutionMethod2(meaningb1, meaningk1, meaningb2, meaningk2);
y = Math.Round(y, 3);
Console.Write($"Tочки пересечения -> ({x}; {y})");

