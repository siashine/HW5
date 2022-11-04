// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

int[] GetArray(int sije)
{
  int[] res = new int[sije];
  for (int i = 0; i < sije; i++)
  {
    res[i] = new Random().Next(0, 100);
    Console.Write($"{res[i]}, ");
  }
  return res;
}
int[] array = GetArray(5);

int minValue = array[0];
int maxValue = array[0];

for (int j = 0; j < array.Length; j++)
{
 if (array[j] > maxValue)
{
  maxValue = array[j];
  //Console.WriteLine($"макс{maxValue}, ");
}
{
  if (array[j] < minValue)
    minValue = array[j];
    //Console.WriteLine($"мин{minValue}, "); 
}
}

int result = maxValue - minValue;
Console.WriteLine();
Console.WriteLine($" разница {result}");