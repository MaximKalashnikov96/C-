// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Веддите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Веддите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.Write("Max = ");
if(number1 > number2) Console.Write(number1);
else Console.Write(number2);
Console.WriteLine(" ");
Console.Write("Min = ");
if(number1 > number2) Console.Write(number2);
else Console.Write(number1);