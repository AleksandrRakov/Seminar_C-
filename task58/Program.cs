// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 1



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
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

// bool MatrixСomparison(int[,] matrix1, int[,] matrix2)
// {
//     if (matrix1.GetLength(1) == matrix2.GetLength(0)) return true;

//     else return false;
// }

int[,] MultiplicationtOfTwoMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixMultiplication = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrixMultiplication[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }

    }
    return matrixMultiplication;

}


int[,] matrix1 = CreateMatrixRndInt(2, 2, 0, 10);
int[,] matrix2 = CreateMatrixRndInt(2, 2, 0, 10);

Console.WriteLine("Матрица 1 :");
PrintMatrix(matrix1);

Console.WriteLine();

Console.WriteLine("Матрица 2 :");
PrintMatrix(matrix2);

Console.WriteLine();

int[,] multiplicationtOfTwoMatrices = MultiplicationtOfTwoMatrices(matrix1, matrix2);

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    Console.WriteLine("Результирующая матрица : ");
    Console.WriteLine();
    PrintMatrix(multiplicationtOfTwoMatrices);

}
else
    Console.WriteLine("Такую матрицу перемножить нельзя ");










