/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

Console.Write("Введите пятизначное число: ");

while(true)
{
    string Number = Console.ReadLine();
    int Num = int.Parse(Number);
    if(Number[0] == Number[4] || Number[1] == Number[3])
        Console.WriteLine($"{Number} -> да");
    else
        Console.WriteLine($"{Number} -> нет");
        break;
}
