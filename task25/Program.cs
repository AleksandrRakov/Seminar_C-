// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите  первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = SumValue(numberA, numberB);
Console.WriteLine($"{numberA},{numberB} -> {result}");

int SumValue(int numA, int numB)
{
    int sum = 1;
    for (int i = 0; i < numB; i++)
    {
        sum = sum * numA;
    }
    return sum;
}