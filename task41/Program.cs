// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

void EnterArray(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"число {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
}

int PositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    return count;
}

EnterArray(array);
Console.WriteLine();
PrintArray(array);
int positiveNumbers = PositiveNumbers(array);
Console.Write($" -> количество положительных чисел  {positiveNumbers}");








