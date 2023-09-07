/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
void PrintNumbers(int num)
{
    if (num >= 1)
    {
        Console.WriteLine(num);
        PrintNumbers(num - 1);
    }
}
Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumbers(number); */

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
m = 3, n = 2 -> A(m,n) = 29

Функция Аккермана — это рекурсивная математическая функция, которая принимает два неотрицательных целочисленных аргумента и возвращает неотрицательное целочисленное значение.
Имеет три базовых случая, определяемых следующим образом:
Если n равно 0, вернуть m +1.
Если m равно 0, рекурсивно вызвать функцию с параметрами n - 1 и 1 в качестве аргументов.
Если ни n, ни m не равны 0, рекурсивно вызовите функцию с n - 1 и результатом вызова функции с n и m - 1 в качестве аргументов.
*/

int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1));
}
Console.Write("Enter the value of m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the value of n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Ackermann(m, n);
Console.WriteLine($"The result of the Ackermann function with m = {m} and n = {n} is: {result}");