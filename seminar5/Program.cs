// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

internal class Program
{
    private static void Main(string[] args)
    {
        int size = ReadInt("Введите размерность массива: ");
        int[] numbers = new int[size];

        FillArrayRandomNumbers(numbers);
        PrintArray(numbers);
        int result = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                result++;
            }
        }

        Console.WriteLine($"В массиве {result} четных чисел");

        // Методы
        void FillArrayRandomNumbers(int[] array) //Заполнение массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(99, 999);
            }
        }

        void PrintArray(int[] array) //Вывод массива на экран
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }


        int ReadInt(string message)  //Функция ввода
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }



//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

internal class Program
{
    private static void Main(string[] args)
    {
        int min = ReadInt("Введите минимальное число массива: ");
        int max = ReadInt("Введите максимальное число массива: ");
        int[] numbers = new int[(ReadInt("Введите размерность массива: "))];

        FillArrayRandomNumbers(numbers);
        PrintArray(numbers);
        int result = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 != 0)
            {
                result += numbers[i];
            }
        }
        Console.WriteLine($"Сумма элементов нечетных позиций = {result}");

        // Методы
        void FillArrayRandomNumbers(int[] array) //Заполнение массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(min, max);
            }
        }

        void PrintArray(int[] array) //Вывод массива на экран
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        int ReadInt(string message)  //Функция ввода
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
//[3 7 22 2 78] -> 76  

int size = ReadInt("Введите размерность массива: ");
int min = ReadInt("Введите минимальное число массива: ");
int max = ReadInt("Введите максимальное число массива: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int maxFillarray = numbers[0];
int minFillarray = numbers[0];

for (int i = 0; i < numbers.Length; i++)

    if (numbers[i] > maxFillarray)
{
    maxFillarray = numbers[i];
}
if (numbers[i] < minFillarray)
{
    minFillarray = numbers[i];
}

Console.WriteLine($"Разница между максимальным и минимальным числом = {maxFillarray - minFillarray}");


// Методы
void FillArrayRandomNumbers(int [] array) //Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray(int[] array) //Вывод массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)  //Функция ввода
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}