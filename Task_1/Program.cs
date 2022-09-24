// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите пятизначное число ");
string? number = Console.ReadLine();

void Palindrom()
{
 if (number!.Length == 5)

 if (number[0] == number[4] && number[1] == number[3])
{
    Console.WriteLine($"{number} - Да");
}
 else
{
        Console.WriteLine($"{number} - Нет");
}
else
Console.WriteLine("Это не пятизначное число");
}
Palindrom ();
