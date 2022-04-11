// HOMEWORK 1

//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Input number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
    Console.WriteLine("Bigger is " + num1);
else if (num2 > num1)
    Console.WriteLine("Bigger is " + num2);
else 
    Console.WriteLine("numbers are equal");
*/

//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Input number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (num2 > max)
    max = num2;
if (num3 > max)
    max = num3;

Console.WriteLine("Bigger is " + max);
*/

//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
    Console.WriteLine("number is even");
else 
    Console.WriteLine("number is odd");
*/

//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;
while (i <= num)
{
    if (i % 2 == 0)
        Console.Write(i + " ");
        i++;
}
*/