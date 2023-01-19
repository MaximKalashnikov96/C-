//  Напишите программу, которая принимает на вход цифру, 
//  обозначающую день недели, и проверяет,
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня: ");
int number = Convert.ToInt32(Console.ReadLine());
// if(number == 1) Console.WriteLine("этот день рабочий");
// else if(number == 2) Console.WriteLine("этот день рабочий");
// else if(number == 3) Console.WriteLine("этот день рабочий");
// else if(number == 4) Console.WriteLine("этот день рабочий");
// else if(number == 5) Console.WriteLine("этот день рабочий");
// else if(number == 6) Console.WriteLine("этот день выходной");
// else if(number == 7) Console.WriteLine("этот день выходной");
// else Console.WriteLine("Такого дня нет");

if (number == 6 || number == 7)
    Console.WriteLine("да");
else if (number > 0 && number < 6)
    Console.WriteLine("нет");
else Console.WriteLine("Такого дня недели нет.");