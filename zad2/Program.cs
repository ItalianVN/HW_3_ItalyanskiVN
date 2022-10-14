/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

void GetDistanceBetweenTwoPoints(int firstX, int secondX, int firstY, int secondY,int firstZ,int secondZ)
{
double result = 0;

int tempX = (secondX - firstX) * (secondX - firstX);
int tempY = (secondY - firstY) * (secondY - firstY);
int tempZ = (secondZ - firstZ) * (secondZ - firstZ);

result = Math.Sqrt(tempX + tempY+tempZ);

Console.WriteLine($"расстояние между двумя точками = {result}");
}

Console.WriteLine("Введите первое значение координаты X:");
int firstX = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе значение координаты X:");
int secondX = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое значение координаты Y:");
int firstY = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе значение координаты Y:");
int secondY = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое значение координаты Z:");
int firstZ = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе значение координаты Z:");
int secondZ = int.Parse(Console.ReadLine());

GetDistanceBetweenTwoPoints(firstX, secondX, firstY, secondY,firstZ,secondZ);