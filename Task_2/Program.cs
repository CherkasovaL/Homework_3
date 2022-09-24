// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = ReadInt("Введите координату x точки А: ");
int y1 = ReadInt("Введите координату y точки А: ");
int z1 = ReadInt("Введите координату z точки А: ");
int x2 = ReadInt("Введите координату x точки В: ");
int y2 = ReadInt("Введите координату y точки В: ");
int z2 = ReadInt("Введите координату z точки В: ");

int a = x2 - x1;
int b = y2 - y1;
int c = z1 - z2;

double length = Math.Sqrt(a * a + b * b + c * c);
Console.WriteLine($"Расстояние = {length}");
