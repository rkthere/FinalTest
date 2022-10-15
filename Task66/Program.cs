/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите положительное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
NaturalNumberSum(number, numberM);


int NaturalNumberSum(int n, int m)
{
    if(n == m)
        return m;
    return n + NaturalNumberSum(n-1,m);
}
int result = NaturalNumberSum(number,numberM);
Console.WriteLine($"Сумма натуральных элементов: {result}");

