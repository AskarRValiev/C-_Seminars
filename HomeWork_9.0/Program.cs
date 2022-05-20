//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumOfNumbers(int x, int y)
{
    if (y > x)
    {
        return y + SumOfNumbers(x, y-1);  
    }
    else
        return x;
}

Console.Write("Input the positive start number: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m < 0)
    {
        Console.WriteLine("Error! Number shall be positive!");
        return;
    }
else
    {
        Console.Write("Input the positive end number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("Error! Number shall be positive!");
            return;
        }
        else
        {
            int sum = SumOfNumbers(m, n);
            Console.WriteLine(sum);
        }
    }


/*
//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
int SumOfDigits(int x, int y)
{   
    if (x > 0)
    {
        y = y + x%10;
        return SumOfDigits(x/10, y);
    }
    else
        return y;
}

Console.Write("Input the positive number: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 0)
{
    Console.WriteLine("Error! Number shall be positive!");
    return;
}
else
{
    int sum = SumOfDigits(x, 0);
    Console.Write(sum);
}
*/

