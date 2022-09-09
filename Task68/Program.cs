// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29



Console.WriteLine($"\nДанная программа вычисляет функцию Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.\n");
Console.WriteLine("Введите m меньшее или равное 3: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m < 1 || m > 3)
{
    Console.Write($"\nУказанное число задано некорректно. Программа прервана. Введите целое положительное число от 1 до 3.\n");
    Console.WriteLine();
    Environment.Exit(0);
}

Console.WriteLine("Если m = 3, введите n меньшее или равное 11,");
Console.WriteLine("если m = 2, введите n меньшее или равное 9600,");
Console.WriteLine("если m = 1, введите n меньшее или равное 19000,");

int n = Convert.ToInt32(Console.ReadLine());
if (m == 3 && (n < 1 || n > 11))
{
    Console.Write($"\nУказанное число задано некорректно. Программа прервана. Введите целое положительное число от 1 до 11.\n");
    Console.WriteLine();
    Environment.Exit(0);
}
else if (m == 2 && (n < 1 || n > 9600))
{

    Console.Write($"\nУказанное число задано некорректно. Программа прервана. Введите целое положительное число от 1 до 9600.\n");
    Console.WriteLine();
    Environment.Exit(0);
}
else if (m == 1 && (n < 1 || n > 19000))
{

    Console.Write($"\nУказанное число задано некорректно. Программа прервана. Введите целое положительное число от 1 до 19000.\n");
    Console.WriteLine();
    Environment.Exit(0);
}

int functionAkkerman = Akk(m, n);

Console.Write($"\nФункция Аккермана = {functionAkkerman}");
Console.WriteLine();
int Akk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akk(m - 1, 1);
    else return Akk(m - 1, Akk(m, n - 1));
}
Console.WriteLine();


