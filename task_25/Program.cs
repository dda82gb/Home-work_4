// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("введите число A");
int numA = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число B");
int numB = int.Parse(Console.ReadLine()!);
int NatStep = numA;

for (int i = 1; i < numB; i++)
{
NatStep = NatStep * numA;
}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("A в степени B = " + NatStep);