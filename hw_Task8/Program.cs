﻿// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

int A = 2;

while(A <= N)
{
    Console.Write(A + " ");
    A = A + 2;
}
Console.WriteLine(" ");
