// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FirstMatrix(int rows, int columns, int min, int max)
{
    int[,] firstMatrix = new int[rows, columns];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            firstMatrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return firstMatrix;
}

int[,] SecondMatrix(int columns, int rows, int min, int max)
{
    int[,] secondMatrix = new int[columns, rows];
    for (int i = 0; i < secondMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            secondMatrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return secondMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
int rows1 = rows;
Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] firstMatr = FirstMatrix(rows, columns, min, max);
int[,] secondMatr = SecondMatrix(columns, rows, min, max);

int[,] ProductMatrix(int rows, int rows1, int min, int max)
{
    int[,] matr = new int[rows, rows1];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {

            for (int g = 0; g < firstMatr.GetLength(1); g++)
            {
                matr[i, j] = matr[i, j] + firstMatr[i, g] * secondMatr[g, j];
            }

        }
    }
    return matr;
}

int[,] result = ProductMatrix(rows, rows1, -2147483648, 2147483647);
Console.WriteLine("Первая матрица:");
PrintMatrix(firstMatr);
Console.WriteLine("Вторая матрица");
PrintMatrix(secondMatr);
Console.WriteLine("Произведение матриц:");
PrintMatrix(result);