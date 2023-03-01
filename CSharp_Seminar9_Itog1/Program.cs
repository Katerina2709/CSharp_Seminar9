// Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// ввод числовых данных с консоли
int ConsoleInputInt (string message)
{
    Console.Write(message);
    int option = Convert.ToInt32(Console.ReadLine());
    return option;
}

// печать натуральных чисел от N до 1
void NaturalNumb (int n)
{
    if (n  == 0) return;
    Console.Write($"{n},  ");
    NaturalNumb (n - 1);
}

int number = ConsoleInputInt ("Введите натуральное число N: ");
if (number < 0)
{
    Console.Write($"Введенное число {number} не натуральное");
}
else
{
    Console.Write ($"N = {number} -> \"");
    NaturalNumb (number);
    Console.Write ($"\b\b\b\"");
}
