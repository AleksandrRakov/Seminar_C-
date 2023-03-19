// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3


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

double[] ArithmeticMeanEachColumn(int[,] matrix)
{
    int size = 0;
    double[] array = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        double sum = 0;

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            sum += matrix[i, j];
         }
        double arithmeticMean = sum / matrix.GetLength(1);
        arithmeticMean = Math.Round(arithmeticMean, 1);
        array[size] = arithmeticMean; 
        size++;
    }
    return array;
}

void PrintArray(double[] arr)
{
    Console.Write($"  [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write($" ]");
}

int[,] array2d = CreateMatrixRndInt(6, 6, 0, 100);
PrintMatrix(array2d);
Console.WriteLine();
double[] arithmeticMeanEachColumn = ArithmeticMeanEachColumn(array2d);
Console.Write($"Среднее арифметическое каждого столбца:");
PrintArray(arithmeticMeanEachColumn);


