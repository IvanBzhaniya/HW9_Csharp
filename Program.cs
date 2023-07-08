﻿/*

Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



int ShowNumbers(int n, int m)
{
    if (n == m) return n;
    else Console.Write(ShowNumbers(n, m + 1) + " ");
    return m;
}

ShowNumbers(8, 0);


Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

int CountSum(int m, int n)
{
    if (m == n) return n;
    return n + CountSum(m, n - 1);
}

Console.WriteLine("enter num1");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter num2");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"sum from {m} to {n} is {CountSum(m, n)}");