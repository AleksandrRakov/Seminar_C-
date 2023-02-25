// Задача 4: Напишите программу, 
// 1.которая принимает на вход три числа 
// 2.выдаёт максимальное из этих чисел.
// Пример:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число 1:");
 int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
 int b = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите число 3:");
 int c = Convert.ToInt32(Console.ReadLine());
   
   int max = a;

    if (b > max)max = b;
    if (c > max)max = c;
    
    Console.WriteLine("Максимальное число:"); 
    Console.WriteLine(max);
