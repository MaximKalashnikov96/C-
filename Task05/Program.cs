﻿// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = -number;
Console.Clear();
Console.WriteLine("все целые числа в промежутке");
if (number >= 0)
while (count <= number)
{
{    
    Console.Write(count+ " ");
    count++;
}
}
else
{
    while(count >= number)
    {
        Console.Write(count+" ");
        count--;
    }
}