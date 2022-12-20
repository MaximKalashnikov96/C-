// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число :");
int num2 = Convert.ToInt32(Console.ReadLine());

bool Multiplicity(int number1, int number2)
{
    return number1 % number2 == 0;
}

int MultiplicitySecond(int number1,int number2)
{
    return number1 % number2;
}

bool result = Multiplicity(num1, num2);
Console.WriteLine(result ? "Кратно" : $"Некратно, остаток = {num1 % num2}" );

int result2 = MultiplicitySecond(num1, num2);
Console.WriteLine(result2 == 0 ? "Кратно" : $"Некратно, остаток = {result2}" );
