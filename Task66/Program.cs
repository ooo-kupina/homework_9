// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine($"\nДанная программа находит сумму натуральных элементов в промежутке от M до N");
Console.WriteLine($"\nЧисла M и N задаёт пользователь\n");
int m = InputNumbers("Введите M меньшее или равное 100: ");
int n = InputNumbers("Введите N меньшее или равное 100: ");
int temp = m;
Console.WriteLine();

if (m > n)
{
    m = n;
    n = temp;
}

PrintSumm(m, n, temp = 0);
Console.WriteLine();
void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов в промежутке от M до N = {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    for (; output < 1 || output > 100;)
    {
        Console.Write($"\nУказанное число задано некорректно. Программа прервана. Введите целое положительное число от 1 до 100.\n");
        Console.WriteLine();
        Environment.Exit(0);
    }
    return output;
}
Console.WriteLine();
