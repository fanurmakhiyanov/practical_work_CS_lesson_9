// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintNaturalNumbers(int numberM, int numberN)
{
    if (numberM > numberN) return;
    if (numberN % 2 == 1)
    {
        numberN--;
    }
    PrintNaturalNumbers(numberM, numberN - 2);
    System.Console.Write($"{numberN}; ");
}

int numberM = Prompt("Введите число 1: ");
int numberN = Prompt("Введите число 2: ");

System.Console.WriteLine();

System.Console.Write($"M = {numberM}, N = {numberN} -> ");
PrintNaturalNumbers(numberM, numberN);
System.Console.WriteLine();