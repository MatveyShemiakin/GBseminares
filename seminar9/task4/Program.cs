// Найдите второй максимум в массиве 
Random rnd = new Random();
int[] arr = new int[10];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100);  
}

int max1 = arr[0];
int max2 = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max1)
    {
        max2 = max1;
        max1 = arr[i];
    }
    else if (arr[i] > max2 && arr[i] < max1)
    {
        max2 = arr[i];
    }
}

if (max1 == max2)  
{
    Console.WriteLine("Второго максимума нет.");
}
else
{
    Console.WriteLine("Второй максимум: " + max2);
}
