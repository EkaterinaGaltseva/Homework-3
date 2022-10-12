/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */


int firstX = Coordinate("x", "A");
int firstY = Coordinate("y", "A");
int firstZ = Coordinate("z", "A");
int secondX = Coordinate("x", "B");
int secondY = Coordinate("y", "B");
int secondZ = Coordinate("z", "B");
int Coordinate(string coorName, string poinName)
{
    Console.Write($"Введите координату {coorName} точки {poinName}: ");
     return Convert.ToInt16(Console.ReadLine());
}
double GetDistant(double firstX, double secondX, double firstY, double secondY, double firstZ, double secondZ)
{
    return Math.Sqrt(Math.Pow(secondX - firstX, 2) + Math.Pow(secondY - firstY, 2) + Math.Pow(secondZ - firstZ, 2));
}
double result = Math.Round (GetDistant(firstX, secondX, firstY, secondY, firstZ, secondZ), 2);
Console.WriteLine($"Расстояне между точками -> {result}");


