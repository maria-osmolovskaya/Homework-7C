/*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

//метод введения количества строк и столбцов

int GetNumberFromConsole (string message)
{
    Console.WriteLine(message);
    int result;
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result>0)
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

int rownumber = GetNumberFromConsole ("Введите количество строк");
int columnnumber = GetNumberFromConsole ("Введите количество столбцов");
int rowindex = GetNumberFromConsole ("Введите номер строки элемента");
int colindex = GetNumberFromConsole ("Введите номер столбца элемента");

int [,] array = InitMatrix (rownumber, columnnumber);
PrintMatrix (array);

if((rowindex<=rownumber) & (colindex<=columnnumber))
    {
        Console.WriteLine($"{array[rowindex-1,colindex-1]}");
    }
else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }