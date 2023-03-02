// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100000)
{
    if (10000 <= number)
    {
        bool Number(int num)
        {
            int num1 = num % 10;
            int num2 = num / 10 % 10;
            int num3 = num / 100 % 10;
            int num4 = num / 1000 % 10;
            int num5 = num / 10000;
            return num1 == num5 && num2 == num4;
        }
    Console.WriteLine(Number(number) ? "является палиндромом" : "нe является палиндромом");
    }
    else
    {
        Console.WriteLine("число не пятизначное");
    }
}
else
{
    Console.WriteLine("число не пятизначное");
}