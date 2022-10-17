/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
Console.Clear();
Console.Write("Массив из трехзначных чисел: ");
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int j = 0; j < count; j++)
    {
        Console.Write($"{array[j]}, ");
    } 
}
void Even (int[] array)
{
    int count = array.Length;
    int res = 0;
    int num1 = 0;
    int num2 = 0;
    int num3 = 0;
    int num4 = 0;
        for (int j = 0; j < count; j++)
    {
    num1 = array[j] / 10;
    num2 = num1 % 10;
    num3 = array[j] % 10;
    num4 = array[j] / 100;
    if (num2 % 2 == 0) res++;
    if (num3 % 2 == 0) res++;
    if (num4 % 2 == 0) res++;
}
    Console.Write($"Количество четных чисел в массиве: {res}");
}
int[] mass = new int[5];
Random rand = new Random();
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rand.Next(100, 1000);
}
PrintArray(mass);
Console.WriteLine();
Even(mass);