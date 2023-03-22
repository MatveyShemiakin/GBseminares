
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int rows = ReadInt("Введите количество строк 1-й матрицы: ");
int columnsRows = ReadInt("Введите количество строк 2-й и колонок 1-й: ");
int columns = ReadInt("Введите количество столбцов 2-й матрицы: ");

//Матрицы можно перемножать с разным количеством строк и столбцов

int[,] array = new int[rows, columnsRows];
int[,] secondArray = new int[columnsRows, columns];
int[,] resultArray = new int[rows, columns];

FillArrayRandom(array);
PrintArray2D(array);

Console.WriteLine();

FillArrayRandom(secondArray);
PrintArray2D(secondArray);

Console.WriteLine();

// Здесь ошибка - количество колонок первой должно совпадать с количеством строк во второй
if (array.GetLength(1) != secondArray.GetLength(0))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}

// почему этот код не в функции?
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

PrintArray2D(resultArray);



// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция заполнения массива рандомными числами от 1 до 9
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Функция вывода двумерного массива в терминал 
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
