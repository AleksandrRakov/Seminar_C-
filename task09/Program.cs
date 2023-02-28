// // 9. Напишите программу, которая выводит
// // случайное число из отрезка [10, 99] и показывает
// // наибольшую цифру числа.
// // 78 -> 8
// // 12-> 2
// // 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число от 10 - 99 -> {number}");
// int first = number / 10;
// int second = number % 10;
// if (first > second)
// {
//     Console.WriteLine($"Наибольшое число -> {first}");
// }
// else
// {
//     Console.WriteLine($"Наибольшое число -> {second}");
// }

// /это тернарный оператор можно писать за место if и else 
// int result = first > second ? first : second;
// Console.WriteLine($"Наибольшое число ->{result}");


int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшое число ->{maxDigit}");
// верхние две строки можно сократить в одну нижнюю

// Console.WriteLine($"Наибольшое число -> {MaxDigit(number)}");

// решение через метод:->
int MaxDigit(int num)
{
    int first = num / 10;
    int second = num % 10;
    int result = first > second ? first : second;  //тернарный оператор
    return result;
}
 