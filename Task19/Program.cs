// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


void Palindrome(int num)
{


    int num1 = 0;
    int a1 = num % 10;
    int a2 = num / 10 % 10;
    int a3 = num / 100 % 10;
    int a4 = num / 1000 % 10;
    int a5 = num / 10000;
    num1 = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;

    if (num == num1) Console.WriteLine("Это палиндром");
    else Console.WriteLine("Это не палиндром");

}

Palindrome(number);
