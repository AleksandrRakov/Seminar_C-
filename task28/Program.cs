// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("введите целое число от 1 до 12:");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(number);

int SumNumbers(int num)
{
    int res = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            res = res * i; // res *= i
        }
    }
    return res;
}
Console.WriteLine($"произведение чисел от 1 до {number} = {result}");