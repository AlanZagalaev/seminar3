// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введи пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99999 && number < 10000)
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
    
else if (number / 10000 == number % 10 && (number / 1000) % 10 == (number / 10) % 10)
{
    Console.WriteLine("вы ввели палиндром");
}
    else
    {
        Console.WriteLine("данное число не является палиндромом");
    }
Console.ReadLine();
