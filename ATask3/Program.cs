/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру
*/

Console.WriteLine("Введите число: ");
string day = Console.ReadLine();

if (day == "1")
{
    Console.WriteLine("понедельник");
}

else if (day == "2")
{
    Console.WriteLine("вторник");
}

else if (day == "3")
{
    Console.WriteLine("среда");
}

else if (day == "4")
{
    Console.WriteLine("четверг");
}

else if (day == "5")
{
    Console.WriteLine("пятница");
}

else if (day == "6")
{
    Console.WriteLine("суббота");
}

else if (day == "7")
{
    Console.WriteLine("воскресенье");
}
else
{
    Console.WriteLine("ввели неправильное число, введите число от 1 до 7");
}