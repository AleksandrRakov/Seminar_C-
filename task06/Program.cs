﻿// Задача 6: Напишите программу, которая 
// 1.на вход принимает число  
// 2.и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Пример:
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());

if (x % 2 == 0) Console.Write("является четным");
else
    Console.Write("Не является четным");
