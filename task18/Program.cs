// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

string result = Range(quarter);
Console.WriteLine(result);

string Range(int numQuarter)
{
    if(numQuarter == 1) return "Координаты х > 0, координаты y > 0";
    if(numQuarter == 2) return "Координаты х < 0, координаты y > 0";
    if(numQuarter == 3) return "Координаты х < 0, координаты y < 0";
    if(numQuarter == 4) return "Координаты х > 0, координаты y < 0";
    return "Введите корректный номер четвeрти";
    
}