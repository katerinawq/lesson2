﻿/*11. Напишите программу, которая выводит случайное 
трёхзначное число и удаляет вторую цифру этого числа.*/
 
int x1 = new Random().Next(0,1000);
int x2 = x1 / 100;
int x3 = x1 % 10;

Console.WriteLine(x1);
Console.Write($"{x2}{x3}");