//Task 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Power(int num1, int num2)
{
    int result = 1;
    while (num2 != 0)
    {
        result *= num1;
        num2--;
    }
    return result;
}

Console.Write("Input A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input B: ");
int b = Convert.ToInt32(Console.ReadLine());

int pow = Power(a, b);
Console.WriteLine($"A to the power of B is: {pow}");
*/

//Task 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumOfDigits (int n)
{
    int result = 0;
    while (n > 0)
    {
      result += n % 10;
      n = n / 10;
    }
    return result;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = SumOfDigits(num);
Console.Write($"Sum of digits is {sum}");
*/

//Task 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//as technical task not defined the method of creating of array, it's creating by random 

int[] CreateArray (int min, int max)
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] printedArray)
{
    for (int i = 0; i < printedArray.Length; i++)
        Console.Write(printedArray[i] + " ");
}

Console.Write("Input min value of array: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value of array: ");
int maximum = Convert.ToInt32(Console.ReadLine());

int[] needArray = CreateArray(minimum, maximum);
PrintArray(needArray);



