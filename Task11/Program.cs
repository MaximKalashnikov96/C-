// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100,1000);
Console.WriteLine($"случайное трехзначное число: {number}");

int firstDigit = number / 100;
int secondDigit = number / 10 % 10;
int thirdDigit = number % 10;

Console.WriteLine(firstDigit);
Console.WriteLine(secondDigit);
Console.WriteLine(thirdDigit);

int doubleNumber = firstDigit * 10 + thirdDigit;
Console.WriteLine(doubleNumber);


// int number = new Random().Next(100,1000);
// Console.WriteLine(number);

// int RemoveSecondDigit(int numb)
// {
//     int firstDigit = numb / 100;
//     int secondDigit = numb % 10;
//     int result = firstDigit * 10 + secondDigit; 
//     return result;
// }
// Console.WriteLine(RemoveSecondDigit(number));