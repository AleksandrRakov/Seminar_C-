// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите номер строки");
int numberi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int numberj = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine();
    }
}

bool CheckingItemQuantity(int[,] matrix, int i, int j)
{
    if (i > matrix.GetLength(0) || j > matrix.GetLength(1))
    {
        return true;
    }
    if (i < 0 || j < 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int SearchingValueElement(int[,] matrix, int i, int j)
{
    int element = matrix[i - 1, j - 1];
    return element;
}


int[,] array2d = CreateMatrixRndInt(10, 10, -100, 100);
string checkingItemQuantity = CheckingItemQuantity(array2d, numberi, numberj)
? "Такого элемента в массиве нет" :
 $"Значение этого элемента -> {SearchingValueElement(array2d, numberi, numberj)}";
Console.WriteLine(checkingItemQuantity );
Console.WriteLine();
PrintMatrix(array2d);

