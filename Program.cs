/*
Напишите программу, которая на вход принимает число и выдает его квадрат ( число умноженное на само себя)

Например, 
4 -> 16
-3 -> 9
-7 -> 49
*/

Console.WriteLine("Введите число");
string namberStr = Console.ReadLine();
int number = Convert.ToInt32(namberStr);

int result = number * number;

Console.WriteLine($"Квадрат числа  {number} = {result}");