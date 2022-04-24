//Task 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] RandomArray (int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 1000);
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int QuantOfEven (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {  
        if (array[i] % 2 == 0)
            count++;
    }
    return count;    
}

Console.Write ("Array will be creat from 1 to 1000. Input size of array: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = RandomArray(n);
PrintArray(myArray);        //not matter  just check
Console.WriteLine(" ");

int eventsQuantity = QuantOfEven(myArray);
Console.Write("Quatntity of event numbers is: " + eventsQuantity);
*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] RandomArray (int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int OddPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)  
            sum += array[i];      
    }
    return sum;
}

Console.Write ("Array will be creat from -100 to 100. Input size of array: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = RandomArray(n);
PrintArray(myArray);        //not matter  just check
Console.WriteLine(" ");

int oddsSum = OddPosition(myArray);
Console.Write("Sum of odds position numbers is: " + oddsSum);
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray (int size)  
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("input " + i + " element: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

void PrintArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

double DiffOfMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    double different = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        else if (array[i] > max)
            max = array[i];
    }
    different = max - min;
    return different;
}

Console.Write("Input size of array: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateArray(arraySize);
PrintArray(myArray);                                        //not matter  just check

Console.WriteLine(" ");
double diff = DiffOfMaxMin(myArray);
Console.Write("Different of max and min number of array is: " + diff);


