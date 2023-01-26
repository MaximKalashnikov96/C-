// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты : ");
Console.Write("A1: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("A2: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("A3: ");
int a3 = Convert.ToInt32(Console.ReadLine());
Console.Write("B1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("B2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("B3: ");
int b3 = Convert.ToInt32(Console.ReadLine());

double range = Distance(a1, b1, a2, b2, a3, b3);
Console.WriteLine(Math.Round(range, 2, MidpointRounding.ToZero));

double Distance (int x1, int y1, int x2, int y2, int x3, int y3)
{
    double result = Math.Sqrt((y1 - x1) * (y1 - x1) + (y2 - x2) * (y2 - x2) + (y3 - x3) * (y3 - x3));
    return result;
}
