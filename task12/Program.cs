// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


// Вывод сторк к "вводу чисел" и сам ввод чисел:

Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

// Решение через if и else:
// if (finalNumber == 0) 
// Console.WriteLine($"Число {number1} кратно числу {number2}");
// else 
// Console.WriteLine($"Числа не кратны остаток от деления равен {finalNumber}");


//  int finalNumber = FinalNumber(number1, number2);
//  Console.WriteLine(finalNumber == 0 ? "кратно" : $"Не кратно -> {finalNumber}");
//  Две верхнии строчки можно заменить на одну нижнюю:

// Console.WriteLine(FinalNumber(number1, number2) == 0 ? "кратно" : $"Не кратно -> {FinalNumber(number1, number2)}");
  
  int finalNumber = FinalNumber(number1, number2);
  string result = finalNumber == 0 ? "кратно" : $"Не кратно -> {finalNumber}";
  Console.WriteLine(result);

// Решение методом:
int FinalNumber(int num1, int num2)
{
    //   return num1 % num2;
    //   или можно сразу без переменной как выше
    int div = num1 % num2;
    return div;
}