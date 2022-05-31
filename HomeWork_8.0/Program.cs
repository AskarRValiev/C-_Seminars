//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
/*
int[,] CreateRndArray(int row, int column)
{
    int [,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
    }
    return array;
}
*/
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
/*
int[,] RowSmallToLarge(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] > array [i, k])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}

Console.Write("Input number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];
matrix = CreateRndArray(n, m);
PrintArray(matrix);
RowSmallToLarge(matrix);
Console.WriteLine();
PrintArray(matrix);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int MinSumOfRows(int[,] array)
{
    int min = 0;
    int minSum = 999999999;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < minSum)
        {
            min = i;
            minSum = sum;
        }
    }
    return min;
}

Console.Write("Input number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];
matrix = CreateRndArray(n, m);
PrintArray(matrix);
Console.WriteLine();

int minRow = 0;
minRow = MinSumOfRows(matrix);
Console.WriteLine("Minimum is row " + (minRow + 1));
*/
//Задача 62. Заполните спирально массив 4 на 4.

int[,] SpiralArray(int n, int m)
{   
    int[,] array = new int[n, m];
    int fill = 1;
    int countRow = 0;
    int countColumn = 0;
    int layer = 0;
   
    while (fill <= n * m)
    {
        for(int i = countRow, j = countColumn; j < array.GetLength(1) - layer; j++)
        {
            array[i, j] = fill;
            fill++;
        }
        countRow++;
        countColumn++;

        for(int i = countRow, j = array.GetLength(1) - countColumn; i < array.GetLength(0) - layer; i++)
        {
            array[i, j] = fill;
            fill++;
        }
        countColumn++;

        for(int i = array.GetLength(0) - countRow, j = array.GetLength(1) - countColumn; j >= layer; j--)
        {
            array[i, j] = fill;
            fill++;
        }
        countRow++;
        countColumn -=2;

        for(int i = array.GetLength(0) - countRow, j = countColumn; i > layer; i--)
        {
            array[i, j] = fill;
            fill++;
        }
        countRow--;
        countColumn++;
        layer++;
       
              
    }
return array;
}


int[,] spiArr = new int[4, 4];
spiArr = SpiralArray(4, 4);
PrintArray(spiArr);
