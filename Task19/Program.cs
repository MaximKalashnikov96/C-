// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
 string s =Console.ReadLine();

void Palindrome(int num)
{

    while (num > 0)
    {
        int Temp = num;
        int rev = 0;
        int dig = num % 10;
        rev = rev * 10 + dig;
        num = num / 10;
    
        if (Temp == rev) Console.WriteLine("Это палиндром");
        else Console.WriteLine("Это не палиндром");
    }
}

Palindrome(number);
