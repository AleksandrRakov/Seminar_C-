// Задача 2: Напишите программу, 
// 1. которая на вход принимает два числа и выдаёт,
// 2. какое число большее, а какое меньшее.
// Пример:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число 1:");
 int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
 int b = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Максимальное число:"); 
    if (a > b) Console.WriteLine(a);
    if (b > a) Console.WriteLine(b);

 
    
 
