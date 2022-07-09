// Задача 2: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int PrintSumlNumbers (int numberM, int numberN)
{
    if (numberM > numberN) return 0;
    return PrintSumlNumbers(numberM, numberN-1)+numberN;
}

int numberM = Prompt("Введите число 1: ");
int numberN = Prompt("Введите число 2: ");

System.Console.WriteLine();

int a = PrintSumlNumbers(numberM, numberN);
System.Console.WriteLine($"Произведение натуральных чисел от {numberM} до {numberN} равняется {a}");
