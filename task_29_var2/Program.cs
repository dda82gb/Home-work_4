// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Введите ряд чисел, разделенных запятой : ");
string? Num = Console.ReadLine();

Num = Num + ",";   

string Rem (string series)
{
  string New = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      New += series[i];
    }
  }
  return New;
}


int[] ArrayNum(string seriesNew)
{ 

  int[] arrayNum = new int[1]; 

  int j =0;

  for (int i = 0; i < seriesNew.Length; i++)
  {
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length){
      seriesNew1 += seriesNew[i];
      i++;
    }
    arrayNum[j] = int.Parse(seriesNew1);    
    if (i < seriesNew.Length-1){
      arrayNum = arrayNum.Concat(new int[] {0}).ToArray();    
    }
    j++;
  }
  return arrayNum;
}
Console.ForegroundColor = ConsoleColor.Green;
void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  Console.Write("-->[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 


string New = Rem(Num);

int[] arrayNum =  ArrayNum(New);

PrintArry(arrayNum);