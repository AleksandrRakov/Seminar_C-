// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6 

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number >= 100 ? $"третья цифра -> {second(number)}" : "третьей цифры нет");

int second(int num)
{
    if (num > 1000)
    {
        while (num >= 999)
        {
            num = num / 10;
        }
    num = num % 10;    
    }
    else
    {num = num % 10;
        ;
    }
    return num;
    }
