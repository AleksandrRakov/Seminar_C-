// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

// решение без метода:
// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int result = firstDigit * 10 + thirdDigit;

// Console.Write(result);

// решение с методом:
int DelDigit (int num) 
{
    int firstDigit = num / 100; 
    int thirdDigit = num % 10; 
    int result = firstDigit * 10 + thirdDigit; 
    return result;
}
int newNumber = DelDigit(number);
Console.WriteLine($"Новое число -> {newNumber}");

// Можно заменить одной строкой,нижней:
// Console.WriteLine($"Новое число -> {DelDigit(number)}");
