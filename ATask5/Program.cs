/*
Напишите программу, которая на вход принимает 3 значное число, а на выходе показывает последнюю цифру этого числа
*/

Console.WriteLine("Введите трехзначное число");
string namberStr = Console.ReadLine();
int number = Convert.ToInt32(namberStr);
number = Math.Abs(number);
if ((number>=100) && (number<=999))
Console.WriteLine (number % 10);
else
{
    Console.WriteLine ("Неверно введено число");
}