// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты : ");
Console.Write("A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("A1: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("B1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

// Math.Pow(a, a1);
// Math.Sqrt(5);

// Math.Pow(b, b1);
// Math.Sqrt(5);

// double d = Math.Sqrt((a-b)*(a-b)+(a1-b1)*(a1-b1));

// double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
// Console.WriteLine(dRound);

double range = Distance(a, a1, b ,b1);
Console.WriteLine(Math.Round(range, 2, MidpointRounding.ToZero));

double Distance(int x1, int y1, int x2, int y2)
{
    double result = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
     return result;
}