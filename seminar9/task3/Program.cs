// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n;


Dictionary<string, int> cache = new Dictionary<string, int>();

int Ackerman(int n, int m)
{
  string key = n.ToString() + "," + m.ToString();
  if (cache.ContainsKey(key))
    return cache[key];

  int result;
  if (n == 0)
    result = m + 1;
  else if (m == 0)
    result = Ackerman(n - 1, 1);
  else
    result = Ackerman(n - 1, Ackerman(n, m - 1));

  cache[key] = result;
  return result;
}

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}


int n = ReadData("Введите число N: ");
int m = ReadData("Введите число M: ");
int sumAckerman = Ackerman(n, m);
PrintData("значение функции Аккермана равно: ", sumAckerman);