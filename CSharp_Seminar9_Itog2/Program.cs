// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// ввод числовых данных с консоли
int ConsoleInputInt (string message)
{
    Console.Write(message);
    int option = Convert.ToInt32(Console.ReadLine());
    return option;
}

//  сумма натуральных элементов в промежутке от M до N
int SumNaturalNumbs (int m, int n)
{
    if (m == n)  return n;
    return m + SumNaturalNumbs (m + 1, n);
}

int numberM = ConsoleInputInt ("Введите натуральное число M: ");
int numberN = ConsoleInputInt ("Введите натуральное число N: ");
if (numberM <= 0 || numberN <= 0)
{
    Console.Write("Оба числа (M и N) должны быть натуральными");
}
else
{
    Console.Write ($"M = {numberM}; N = {numberN} -> {SumNaturalNumbs (numberM, numberN)}");
}
