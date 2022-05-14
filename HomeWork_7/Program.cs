//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
void CreateRandomMatrix (int m, int n)
{
    double [,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10) + Math.Round(new Random().NextDouble(), 1);  //приходится изгаляться
            Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 2)
{
    Console.WriteLine("Error! Number of rows must be greather than 1!");
    return;
}
Console.Write("Input number of columns: ");
int y = Convert.ToInt32(Console.ReadLine());
if (y < 2)
{
    Console.WriteLine("Error! Number of columns must be greather than 1!");
    return;
}

CreateRandomMatrix(x, y);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Так как в ТЗ условие чётко не обозначено, то позиции вводимого элемента начинаются с нуля.
int[,] CreateRandomIntMatrix ()
{
    int [,] matrix = new int[5, 6];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
    return matrix;
}

/*

void FindMatrixElement(int [,] array, int m, int n)
{
    if (m >= array.GetLength(0) || n >= array.GetLength(1))
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine(array[m, n]);
    }
}



Console.Write("Input number of row: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 0)
{
    Console.WriteLine("Error! Number of rows must be greather than 0!");
    return;
}
Console.Write("Input number of column: ");
int y = Convert.ToInt32(Console.ReadLine());
if (y < 0)
{
    Console.WriteLine("Error! Number of columns must be greather than 0!");
    return;
}

FindMatrixElement(CreateRandomIntMatrix(), x, y);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//В решении используется метод CreateRandomIntMatrix из предыдущей задачи.

void ColumnAverage(int[,] array)
{
    double sum = 0;
    double average = 0;
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        average = Math.Round(sum / array.GetLength(0), 1);
        Console.Write(average + "; ");
        sum = 0;
        average = 0;
    }
}

ColumnAverage(CreateRandomIntMatrix());