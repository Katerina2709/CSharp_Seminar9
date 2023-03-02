// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// ввод числовых данных с консоли
int ConsoleInputInt (string message)
{
    Console.Write(message);
    int option = Convert.ToInt32(Console.ReadLine());
    return option;
}

//  вычисление функции Аккермана 
int AckermanFunction (int argm, int argn)
{
    if (argm == 0)  return argn + 1;
    if (argn == 0)  return AckermanFunction (argm - 1, 1);
    return AckermanFunction (argm - 1, AckermanFunction (argm, argn - 1));
}

int m = ConsoleInputInt ("Введите целое число M >= 0: ");
int n = ConsoleInputInt ("Введите целое число N >= 0: ");
if (m < 0 || n < 0)
{
    Console.Write("Оба числа (M и N) должны быть >= 0");
}
else
{
    Console.Write ($"m = {m}; n = {n} -> A({m},{n}) = {AckermanFunction (m, n)}");
}
