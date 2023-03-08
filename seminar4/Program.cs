internal class Program
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