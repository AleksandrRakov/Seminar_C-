// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет 


Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 8)
{
    Console.WriteLine(week(number) ? "да" : "нет");
    bool week(int num)
    {
        return num == 6 || num == 7;
    }
}
else
{
    Console.WriteLine("введите число от 1 до 7 ");
}




// if (number == 1) Console.WriteLine("понедельник");
// else if (number == 2) Console.WriteLine("вторник");
// else if (number == 3) Console.WriteLine("среда");
// else if(number == 4) Console.WriteLine("четверг");
// else if(number == 5) Console.WriteLine("пятницпа");
// else if(number == 6) Console.WriteLine("суббота");
// else if(number == 7) Console.WriteLine("воскресенье");

//  else Console.WriteLine("неверное число");