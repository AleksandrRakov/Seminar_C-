//  Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трёхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999) 
{
        Console.WriteLine(second(number));

    int second(int num)
    {
        num = num % 100;
        num = num / 10;
        return num;
    }
}
else Console.WriteLine("Число не является трезначным");

