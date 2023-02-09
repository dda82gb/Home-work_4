// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int [] Num = new int[8];
Console.Write("[");

for (int i = 0; i < Num.Length ; i++)
 {
    Num [i] = new Random().Next(1,50);
    Console.Write( " " + Mas (i)+ " ");
 }
Console.Write("]");

int Mas (int a)
{
    return Num[a];
}

