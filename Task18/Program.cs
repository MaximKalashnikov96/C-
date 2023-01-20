// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти: ");
int x = Convert.ToInt32(Console.ReadLine());

string range = Quarter(x);
Console.WriteLine(range);

string Quarter(int num)
{
    if (num == 1) return ("x > 0 ; y > 0");
    if (num == 2) return ("x < 0 ; y > 0");
    if (num == 3) return ("x < 0 ; y < 0");
    if (num == 4) return ("x > 0 ; y < 0");
    return ("Введен неправельный номер четверти");
}