// Задача 8: Напишите программу, которая 
// 1.на вход принимает число (N), 
// 2.а на выходе показывает все чётные числа от 1 до N.
// Пример:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int A = N;
int index = 1;
while (index < A)
{
    if

     (N % 2 == 0)
    {
        Console.WriteLine(N);
    }

    N = N - 1;
    index++;
}
