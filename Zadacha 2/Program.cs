/*
Напишите программу, которая на вход принимает 2 числа и проверяет является ли первое число квадратом второго ( число умноженное на само себя)
*/

Console.WriteLine("Введите число 1");
string input0 = Console.ReadLine();
Console.WriteLine("Введите число 2");
string input1 = Console.ReadLine();
int num0 = Convert.ToInt32(input0);
int num1 = Convert.ToInt32(input1);

if ( (num1 * num1) == num0 )
{
    Console.WriteLine($"Число {num1} является квадратным корнем числа {num0}");
} else
{
    Console.WriteLine($"Число {num1} не является квадратным корнем числа {num0}");
}
