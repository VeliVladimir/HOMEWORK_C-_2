// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.Write ("Введите трехзначное число: ");
int anyNumber = Convert.ToInt32 (Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 1)
{
    Console.WriteLine("Вторая цифра " + anyNumberText[1]);
}