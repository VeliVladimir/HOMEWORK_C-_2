// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear ();
Console.Write ("Введите цифру дня недели: ");
int dayNumber = Convert.ToInt32 (Console.ReadLine());
void CheckingTheDayOfTheWeek (int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
    Console.WriteLine ("этот день выходной");
    }
else if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine ("Дня недели не существует");
}
else Console.WriteLine ("Это будний день недели");
}
CheckingTheDayOfTheWeek(dayNumber);