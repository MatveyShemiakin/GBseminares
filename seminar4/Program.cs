/internal class Program
{
    private static void Main(string[] args)
    {
        // Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
        int GetCountDigit(int number)
        {
            int count = 0;
            int numberA = number;
            while (numberA != 0)
            {
                numberA = numberA / 10;
                count++;
            }

            return count;
        }
        Console.Write("Ввидите число:");
        int A = int.Parse(Console.ReadLine());

        Console.Write($"Количество цифр {GetCountDigit(A)}");
    }
}
//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. 
NewMethod ()

    static void NewMethod()
    {
        static int GetMultiplyALLDigitis(int N)

        {
            int result = 0;

            for (int i = 1; i <= NativeOverlapped; i++)
            {
                result = result * i;
            }

            return result;
        }
        Console.Write("Ввидите число:");
        int A = int.Parse(Console.ReadLine());

        Console.Write($"Произведение чисел от 1 до {CompCountDigit(A)}");
    }

//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

static void NewMethod(int v)

{
    object value = *v[]; array = new int[8](1,2,3,4,5,6,7,8);
    for (int i = 0; i < array.Lenght; i++)
    {
        array[i] = new Random().Next(0, 2);
    }

    void PrintArray(int[] num)
    {
        while (count < num.Lenght -1)
        {
           
            Console.Write($"{num[count]}");
            count++;
        }
    }
}
*/

//Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
ToDegree(numberA, numberB);


// Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

// Функция ввода
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


// Метод читает данные от пользователя
int ReadDataStr(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод выводит результат пользователю
void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}


//Метод считает сумму цифр числа используя остаток от деления
int SummaNumDigRemOfDiv(int num)
{
    int res = 0;
    while (num >0)
    {
        res = res + num%10;
        num = num /10;
    }
    return res;
}


//Начало основного кода

//Вводим данные с консоли
int number = ReadDataStr("Введите положительное, целое число: ");


// Вычисляем сумму методом RemOfDig
DateTime d2 = DateTime.Now;
int summaRemOfDiv = SummaNumDigRemOfDiv(number);


// Печатаем результат: 
PrintData("(Метод RemOfDiv) Сумма цифр числа равна: ", summaRemOfDiv);
Console.Write("Время решения по методу RemOfDig равно: ");
Console.WriteLine(DateTime.Now - d2);

*/
///Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using System;

class Program 
{
    static void Main(string[] args) 
    {
        int[] arr = new int (1, 2, 3, 4, 5, 6, 7, 8);
        for (int i = 0; i < arr.Length; i++) 
        {
            Console.WriteLine(arr[i]);
        }
    }
}