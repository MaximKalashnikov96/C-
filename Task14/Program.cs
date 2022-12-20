// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0) 
Console.WriteLine("да");
else 
Console.WriteLine("нет");

// Console.WriteLine("Введите целое число:");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Multiplicity(number) ? "Да" : "Нет");

// bool Multiplicity(int num1)
// {
// return (num1 % 7 == 0) && (num1 % 23 == 0);
// }