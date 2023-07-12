// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число больше 1:");
int number = int.Parse(Console.ReadLine());

///Метод вывода натуральных чисел от N до 1:
void NumberCounter (int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NumberCounter (number - 1);
}

NumberCounter(number);

﻿/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/



Console.WriteLine("            Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число M:");
int numberN = int.Parse(Console.ReadLine());

///Метод нахождения суммы натуральных элементов в промежутке от M до N
void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

GapNumberSum(numberM, numberN, 0);


﻿/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine("           Введите начальное число A:");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число B:");
int numberB = int.Parse(Console.ReadLine());

///Метод вычисления функции Аккермана:
int AckermannFunction (int numberA, int numberB)
{
    if (numberA == 0) return numberB + 1;
    if (numberA != 0 && numberB == 0) return AckermannFunction(numberA - 1, 1);
    if (numberA > 0 && numberB > 0) return AckermannFunction(numberA - 1, AckermannFunction(numberA, numberB - 1));
return AckermannFunction(numberA, numberB);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberA},{numberB}) = {AckermannFunction(numberA, numberB)}");