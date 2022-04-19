//Task 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// вариант 1, сложный, сам иногда путаюсь


bool Palindrom (int num)        //head method - compare last & most digit
{
    int x1, x2, x3, x4;
    x1 = LSB(num);              //compare 1 and 5 digits of 5th digits number
    x2 = MSB(num);
    if (x1 != x2)               //if not equal
        return false;           // return to head programm
    else                        //if equal, make 3 digits number from 5th digits number
        {
            num = num / 10;
            num = num - 1000 * x2;
            x3 = LSB(num);      //getting 1 and 3 digits from 3rd digits number (or 2 and 4 digits of 5th digits number)
            x4 = MSB(num);
            if (x3 == x4)
                return true;
            else    
                return false;
        }
}

int LSB (int n)                   //selection last digit
{
    return n % 10;
}

int MSB (int n)                    //selection most digit
{
    int i = 0;
    while(n > 10)
    {
        n = n / 10;
        i++;
    }
    return n;
}

Console.Write("Input number: ");                    //input data
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)               //check range
    Console.Write("Wrong number!");
else
{
    
    bool result = Palindrom(number);                //result output
    if (result == true)
        Console.WriteLine("It's palindrom");
    else    
        Console.WriteLine("Isn't palindrom");
}



/*
//Вариант 2, простой

bool Palindrom(int num)                         //compare method
{
    string s1 = num.ToString();                 // int to string
    if (s1 [0] != s1 [4])                       //compare first and last number
        return false;
    else 
    {
        if (s1 [1] == s1 [3])                   // compare second and fourth number
            return true;
        else   
            return false;
    }

}

Console.Write("Input number: ");                    //input data
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)               //check range
    Console.Write("Wrong number!");
else
{
    bool result = Palindrom(number);                //result output
    if (result == true)
        Console.WriteLine("It's palindrom");
    else    
        Console.WriteLine("Isn't palindrom");
}
*/


//Task 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Pifagor3D (double xDotA, double yDotA, double zDotA, double xDotB, double yDotB, double zDotB)
{
    double length = Math.Sqrt((xDotB - xDotA) * (xDotB - xDotA) + (yDotB - yDotA) * (yDotB - yDotA) + (zDotB - zDotA) * (zDotB - zDotA));
    return length;
}

Console.Write("Input XA: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input YA: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input ZA: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input XB: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input YB: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input ZB: ");
double zB = Convert.ToDouble(Console.ReadLine());

double result = Pifagor3D(xA, yA, zA, xB, yB, zB);
Console.Write("Distance between A & B is " + result);
*/

//Task 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void CubeTable(int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.Write(Math.Pow(i, 3) + " ");
        i++;
    }
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

CubeTable(number);
*/