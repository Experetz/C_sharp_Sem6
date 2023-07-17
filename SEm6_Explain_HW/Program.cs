﻿/*
Задача 38: Задайте массив случайных вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

//Create array 
double[] GetRandomDoubleArray(int size)
{
    double[] array = new double[size];
    for (int i = 0 ; i < array.Length; i++)
       {
        array[i] = Math.Round(new Random().NextDouble() * new Random().Next(1, 11), 2); 
        }
    return array;
}

//Print array. How to print array through the string

void PrintDoubleArrayConsole(double[] array)
{
string str = String.Join("  ", array);
Console.Write($"Array:   {str}");

}

double[] array = GetRandomDoubleArray(10);
PrintDoubleArrayConsole(array);

double max = array.Max();
double min = array.Min();
/*for (int i = 0 ; i < array.Length; i++)
    {
        if(array[i] < min)
       min = array[i];
        if(array[i] > max)
        max = array[i];

    }
*/
Console.WriteLine($"The difference between array MAX {max} and MIN {min} is {Math.Round(max - min, 2)}");  