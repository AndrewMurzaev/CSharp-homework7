// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] MassNums(int row, int column, int from, int to)
// {
//     double[,] arr = new double[row, column];

//     for (int i = 0; i < row; i++)
//         for (int j = 0; j < column; j++)
//             arr[i, j] = new Random().Next(from, to + 1) + new Random().NextDouble();
//     return arr;
// }

// void Print(double[,] arr)
// {
//     double row = arr.GetLength(0);
//     double column = arr.GetLength(1);

//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//             Console.Write($" {arr[i, j], 4} ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Enter the number of rows: ");
// int row_num = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the number of columns: ");
// int column_num = int.Parse(Console.ReadLine()!);

// Console.Write("Enter the min number of massive ");
// int start = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the max number of massive ");
// int stop = int.Parse(Console.ReadLine()!);

// double[,] mass = MassNums(row_num, column_num, start, stop);
// Print(mass);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в
// двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Console.WriteLine("Input the row: ");
// int pos1 = int.Parse(Console.ReadLine()!) - 1;
// Console.WriteLine("Input the column ");
// int pos2 = int.Parse(Console.ReadLine()!) - 1;

// void Print(int[,] arr)
// {
//     int row = arr.GetLength(0);
//     int column = arr.GetLength(1);

//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//             Console.Write($" {arr[i, j],4} ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Input the number of rows: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Input the number of columns: ");
// int m = int.Parse(Console.ReadLine()!);

// Random random = new Random();
// int[,] arr = new int[n, m];

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = random.Next(10, 99);

//     }
// }

// Print(arr);
// if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
// {
//     Console.WriteLine("The element doesn't exist  ");
// }
// else
// {
//     Console.WriteLine("array element value = {0}", arr[pos1, pos2]);
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
//  элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] arr = MassNums(3, 4, 0, 10);
PrintArray(arr);
void PrintArray(int[,] PrArray)
{
    for (int i = 0; i < PrArray.GetLength(0); i++)
    {
        for (int j = 0; j < PrArray.GetLength(1); j++)
        {
            Console.Write($"{PrArray[i, j],4}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

Console.WriteLine();
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ sum / arr.GetLength(0)} ");
}
