﻿/*Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8 12-> 2 85 -> 8
10 99*/
 
int num = new Random().Next(10,100);

Console.WriteLine(num);

int c1 = num / 10;
int c2 = num % 10;

if(c1<c2)
{
    Console.WriteLine (c2);
}
else 
{
    Console.WriteLine (c1);
}