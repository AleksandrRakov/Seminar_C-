﻿// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

int finalNumber = FinalNumber(number1, number2);
if (finalNumber ==0) Console.WriteLine($"Число {number1} кратно числу {number2}");
else Console.WriteLine($"Числа не кратны остаток от деления равен {finalNumber}");

int FinalNumber(int num1, int num2)
{
    int div = num1%num2;
  return div;
}
// Console.WriteLine("Введите первое число:");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Второе число:");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int remainsDigits = RemainsDigits(number1, number2);

// Console.WriteLine(remainsDigits == 0 ? "Кратно" : $"Не кратно, остаток -> {remainsDigits}");

// int RemainsDigits(int num1, int num2)
// {
//     return num1 % num2;
//  }