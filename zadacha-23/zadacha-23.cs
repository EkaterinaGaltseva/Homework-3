/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */


void GetNumber(int NumberN)
{
    
    Console.Write($"{NumberN} -> ");
    for (int i = 1; i <= NumberN; i++)
    {
        double result = Math.Pow(i, 3);
        Console.Write($"{result}, ");
    }
    
}

Console.Write("Введите число N: ");
int numb = int.Parse(Console.ReadLine());
GetNumber(numb);