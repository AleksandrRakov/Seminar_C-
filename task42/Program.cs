// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10



Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

string decToBin = DecToBin(number);
Console.WriteLine(decToBin);

string DecToBin(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;


}



// public class MyProgram
// {
//     public static void Main(string[] args)
//     {
//         int x;

//         Console.WriteLine("введите число");
//         x = (int)inputValue();
//         int index;

//         index = 0;
//         while (x > 0)
//         {
//             index = x % 2;
//             x = (int)((double)x / 2);
//             Console.Write(index);
//         }
//     }

//     private static double inputValue()
//     {
//         double result;
//         while (!double.TryParse(Console.ReadLine(), out result)) ;
//         return result;
//     }
// }

