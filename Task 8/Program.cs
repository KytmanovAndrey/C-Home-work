﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
int b = 2;

if (a>=b) 
{
    Console.Write(a + " -> " + b);
    while(a-2>=b)
{
    b = b + 2;
    Console.Write(", " + b);
}
}
b = 0;
if (a-1<b)
{
    Console.Write(a + " -> " + b);
    while(a+1<b)
{
    b = b - 2;
    Console.Write(", " + b);
}
}

// Console.WriteLine("Введите число ");
// int a = int.Parse(Console.ReadLine());

// Console.WriteLine("Четные числа в промежутке 1 до {0}:", a);

// for (int i = 2; i<a; i+=2)
// {
//     Console.Write(i+ ", ");
// }
// for (int i = 0; i>a; i-=2)
// {
//     Console.Write(i+ ", ");
// }
// if (a!=1)
// Console.WriteLine(a);

int[] array = new int[10];
