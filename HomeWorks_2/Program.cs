//Homework 2   

//Task 10
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondNum(int number)
{
    int result = (number / 10) % 10;
    return result;
}

Console.WriteLine("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write(SecondNum(num));
*/

//Task 13
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//Вариант 1
/*
int ThirdNumber(int number)
{
    int y = number;
    int i = 0;
        while (y != 0)  //this cycle are counting number of digits
        {
        y = y/ 10;
        i++;
        }
    if (i < 3) return (-1); //if 3'rd number is missing
    else
        {
        double result = (number / Math.Pow(10, (i-3))) % 10;
        return (int) result;
        }
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());  

int thirdNum = ThirdNumber(num);
if (thirdNum == -1)
    Console.WriteLine("No third number");
else 
    Console.WriteLine("Third number is: " + thirdNum);
*/

//Вариант 2
/*
char ThirdNumber(int number)
{
    string s1 = number.ToString();
    if (s1.Length < 3)
        return 'N';
    else
    {
        char result = s1[2];
        return result;
    }

}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());  

char res = ThirdNumber(num);
if (res == 'N')
    Console.WriteLine("No third number");
else 
    Console.WriteLine("Third number is: " + res);
*/

//Task 15
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool IsHoliday(int dayNum)
{
    if (dayNum == 6 || dayNum == 7)
        return true;
    else
        return false;
}

Console.WriteLine("Input day of week number: ");
int num = Convert.ToInt32(Console.ReadLine());
    if (num < 1 || num > 7)
    {
        Console.WriteLine("Wrong day's number");
        Environment.Exit(-1);
    }

bool holiday = IsHoliday(num);
if (holiday == true)
    Console.WriteLine("It's HOLIDAY!!!");
else 
    Console.WriteLine("It's no holidai! Go to work!");

