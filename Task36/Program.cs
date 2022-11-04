﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);
    Console.Write($"{res[i]}, ");
  }
  return res;
}
int[] array = GetArray(4, -100, 100);


int sum = 0;

for (int z = 1; z < array.Length; z += 2)
{
  if (z % 2 == 1)
    sum = sum + array[z];
}

Console.WriteLine($"Сумма элементов на нечётных позициях = {sum}");
