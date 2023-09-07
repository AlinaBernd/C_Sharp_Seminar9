﻿/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*void PrintNumbers(int num)
    {
        if (num >= 1)
        {
            Console.WriteLine(num);
            PrintNumbers(num - 1);
        }
    }
Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumbers(number);*/

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SumNumbers(int numM, int numN)
{
    if (numM > numN)
        return 0;
    else
        return numM + SumNumbers(numM + 1, numN);
}

Console.Write("Input the number M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number N: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = SumNumbers(num1, num2);
Console.WriteLine($"The sum of the natural numbers from {num1} to {num2} is: {sum}");


/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/