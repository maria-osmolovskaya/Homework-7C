/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

//метод введения количества строк и столбцов

int GetNumberFromConsole (string message)
{
    Console.WriteLine(message);
    int result;
    while(true)
    {
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
int[,] InitMatrix (int m, int n)
{
    int[,]matrix = new int [m,n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(0,10);
        }
    }
    return matrix;
}

// метод печати матрицы
void PrintMatrix (int[,]matrix)
{
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// метод нахождения среднего по столбцам
void AverageColumn(int [,] matrix)
{
double sum = 0;
double columnaverage = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i,j];
                }
                columnaverage = (sum/matrix.GetLength(0));
                Console.Write($"{columnaverage}  ");
            }
    Console.WriteLine();
}

int rownumber = GetNumberFromConsole ("Введите количество строк");
int columnnumber = GetNumberFromConsole ("Введите количество столбцов");
int [,] matrix = InitMatrix (rownumber, columnnumber);
PrintMatrix (matrix);
Console.WriteLine("Среднее арифметическое каждого столбца:");
AverageColumn(matrix);
