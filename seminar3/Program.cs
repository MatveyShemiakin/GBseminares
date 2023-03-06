// 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

int Num = ReadData("Введите 5-ти значное число");

 bool answer = PaliTest(Num);

 if(answer == true) PrintData("Число: " + Num + " является палиндромом :)");
 if(answer == false) PrintData("Число: " + Num + " не является палиндромом :(");

bool PaliTest(int num)
{
     bool res = false;
     int d1 = num / 10000;
     int d2 = (num / 1000) % 10;
     int d3 = (num / 10) % 10;
     int d4 = num % 10;
     res = ((d1 == d4) && (d2 == d3)) ? true : false;
     return res;
}
int ReadData(string msg)
{
     Console.WriteLine(msg);
     return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg )
{
     Console.WriteLine(msg);
}

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


 int coordX1 = ReadData("Введите координату x1");
 int coordX2 = ReadData("Введите координату x2");
 int coordY1 = ReadData("Введите координату y1");
 int coordY2 = ReadData("Введите координату y2");
 int coordZ1 = ReadData("Введите координату z1");
 int coordZ2 = ReadData("Введите координату z2");

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
double CalcLen(int x1, int x2, int y1, int y2, int z1, int z2)
{
     double res = 0;
     res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(z1 - z2, 2));
     return res;
}
 double lenght = CalcLen(coordX1,coordX2,coordY1,coordY1,coordZ1,coordZ2);

void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}
PrintData("Расстояние между точками равно: ", lenght);

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int num = ReadData("Введите N: ");

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

string LineBuilder(int n, int p)
{
    string s = "";
    for (int i = 1; i <= n; i++)
    {
        s += Math.Pow(i, p).ToString() + "\t ";
    }
    return s;
}
string line1 = LineBuilder(num, 1);
string line2 = LineBuilder(num, 3);

void PrintData(string msg1, string msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}
PrintData(line1,line2);