// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
//  Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int numM, int numN)
{
    if (numM > numN) return numM + SumNumbers(numM - 1, numN);
    if (numM == numN) return numM;
    else return numN + SumNumbers(numM, numN - 1);
}

Console.WriteLine("Введите натуральное число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int numberN = Convert.ToInt32(Console.ReadLine());
int sumNumbers = SumNumbers(numberM, numberN);
Console.Write($"Сумма чисел -> {sumNumbers}");