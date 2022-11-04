﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);
    Console.Write($"{res[i]} ");
  }
  return res;
}
int[] array = GetArray(6, 100, 1000);

int evenNumber = 0;

foreach (int el in array)
{
  if (el % 2 == 0)
    evenNumber++;
}

Console.WriteLine();
Console.WriteLine($"Колличество четных чисел - {evenNumber}");