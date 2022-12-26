﻿/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int GetNumberFromConsole (string message)
{
    Console.WriteLine(message);
    int result;
    {
    while (true)
       if (int.TryParse(Console.ReadLine(), out result))
       {
        break;
       }
    else
    {
        Console.WriteLine("Это не число");
    }
    }
    return result;
}

//метод инициализации и заполнения матрицы
double [,] InitMatrix (int m, int n)
{
    double [,] matrix = new double [m,n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i,j] = Math.Round(20*rnd.NextDouble()-10,1);
        }
    }
      return matrix;
}

void PrintMatrix(double[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
}
}


int m = GetNumberFromConsole ("Введите количество строк");
int n = GetNumberFromConsole ("Введите количество столбцов");

double [,] matrix = InitMatrix(m,n);

PrintMatrix(matrix);
