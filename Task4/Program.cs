﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Clear();
Console.Write("Введите number1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите number2: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите number3: ");
int number3 = int.Parse(Console.ReadLine());
int max = number1;
if (number2 > number1) 
max = number2;
if (number3 > number2) 
max = number3;
Console.Write("max = ");
Console.WriteLine(max);

