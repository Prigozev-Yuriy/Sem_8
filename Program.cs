// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Матрица - прямоугольная таблица размером m(строчки) на n(cтолбцов)
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество cтолбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// if (rows != columns)
// {
//     Console.WriteLine("Error");
//     return; // Программа завершает работу кода полностью
// }

// int[,] result = GetMatrix(rows, columns, 0, 10);
// // таблица 3 на 4, числа: от 0 до 10 включительно
// PrintMatrix(result);
// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n]; // [кол-во_строк, кол-во_столбцов]
//     for (int i = 0; i < matrix.GetLength(0); i++) // m, цикл по строчкам
//     {
//         // i, k, m, n, j
//         for (int j = 0; j < matrix.GetLength(1); j++)// n, цикл по столбцам
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) // m, цикл по строчкам
//     {
//         // i, k, m, n, j
//         for (int j = 0; j < matrix.GetLength(1); j++)// n, цикл по столбцам
//         {
//             Console.Write(matrix[i, j] + "\t"); // Tab между элементами матрицы
//         }
//         Console.WriteLine();
//     }
// }
// PascalCase - методы 
// camelCase - переменные и массивы
// void ChangeRows(int[,] matr)
// {
//     int lastRowIndex = matr.GetLength(0) - 1; // Номер последней строчки
//     for (int i = 0; i < matr.GetLength(1); i++)
//     {
//         int temp = matr[0, i]; // temp = matr[0,0] => temp = 1
//         matr[0, i] = matr[lastRowIndex, i]; // matr[0, 0] = matr[2, 0] => matr[0, 0] = 7
//         matr[lastRowIndex, i] = temp; // matr[2, 0] = temp
//     }
// }
// Console.WriteLine("Поменяли 1 и последнюю строчку местами");
// ChangeRows(result);
// PrintMatrix(result); // Видоизмененная матрица (поменяли 1 и последнюю строчку)

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int[,] ChangeMatrix(int[,] matrix)
// {
//     int[,] res = new int[matrix.GetLength(0), matrix.GetLength(1)];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             res[j, i] = matrix[i, j]; // res[столбец, строка] = matrix[строка, столбец]
//         }
//     }
//     return res;
// }
// Console.WriteLine();
// PrintMatrix(ChangeMatrix(result));


// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец , на пересечении которых расположен наименьший элемент массива.

int rows = 3;

int columns = 3;

int[,] matrix = new int[rows, columns]; // 3 строчки на 3 столбца 

int min = int.MaxValue;
int indexMinRow = 0; // Номер строчки с мин элементом
int indexMinColumn = 0;// Номер столбца с мин элементом

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11);
        Console.Write(matrix[i, j] + "\t"); // 1    2   3 
        if (matrix[i, j] < min)
        {
            min = matrix[i, j];
            indexMinRow = i;
            indexMinColumn = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"min: {min}");
Console.WriteLine($"Стр с мин. элементом: {indexMinRow}");
Console.WriteLine($"Стл с мин. элементом: {indexMinColumn}");

Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (i != indexMinRow)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j != indexMinColumn)
            {
                Console.Write(matrix[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }
}