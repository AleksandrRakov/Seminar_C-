﻿// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

TableSquare(number);

void TableSquare(int num)
{
    int index = 1;
    int result = 0;
    while (index <= num)
    {
        result = index * index * index;
        Console.WriteLine($"{index,5} ->  {result,5}");
        index++;
    }
}

