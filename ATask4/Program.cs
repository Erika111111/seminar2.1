/*
Напишите программу, которая на входе принимает число N,  а на выходе показывает все целые числа в промежутке от -N до N
*/

Console.WriteLine("Введите число");
string namberStr = Console.ReadLine();
int number = Convert.ToInt32(namberStr);
number = Math.Abs(number);

for (int i = (-number); i <= number; i++)
{
    Console.Write(i+ " ");
}

