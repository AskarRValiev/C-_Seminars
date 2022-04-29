//Task 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Хотел сделать динамический массив, заморочился со списками, в принципе раобрался, но потом вспомнил, то тема все же 
// про массивы и оставил ограниченный размер

/*
void AmountPositive(int[] array)             //решение
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    Console.WriteLine("Amounts of digits more than 0 is: " + count);
}

int[] InputNumbers()                        //метод ввода чисел
{
    int[] array = new int [10]; 
    Console.WriteLine("Input 10 digits: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }   
    PrintArray(array);
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
}

AmountPositive(InputNumbers());
*/

// Task 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
int[] ToBinary(int num)             //решение задачи
{

    int[] array = new int[16];
    for(int i = 15; i != 0; i--)
    {
        if (num % 2 == 0)
        {;
            array[i] = 0;
            num = num / 2;
        }
        else
            {
                array[i] = 1;
                num = num / 2;
            }
    }
    return array;
}

void PrintArray (int[] array, int num)
{
    Console.Write(num + " to binary is: 0b");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine(" ");
}

Console.Write("Input number less or equal 32 767: ");
int n = Convert.ToInt16(Console.ReadLine());
int[] binaryArray = ToBinary(n);
PrintArray(binaryArray, n);
*/

// Task 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//Решение в задаче на сайте не верное, должно быть (-0.5; -0.5)

double[] GraphCross(double k1, double k2, double b1, double b2)
{
    double[] array = new double[2];
    array[0] = (b2 - b1) / (k1 - k2);
    array[1] = k1 * array[0] + b1;
    return array;
}

Console.WriteLine("Input coefficients:");
Console.Write("k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2)
    Console.WriteLine("Lines are parallel");
else
{
    double[] coordinate = new double[2];
    coordinate = GraphCross(k1, k2, b1, b2);
    Console.WriteLine("Cross coordinate: x = " + coordinate[0] + " y = " + coordinate[1]);
}
