// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int result = sumNumbers(number);

Console.WriteLine($"{number} -> {result}");

int sumNumbers(int num)
{
    if (num < 0) num = -num;
    int Sum = 0;

    for (int i = 0; 0 < num; i++)
    {
        int num1 = num % 10;
        num = num / 10;
        Sum = Sum + num1;
    }
    return Sum;
}

