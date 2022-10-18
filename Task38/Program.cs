/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */
Console.Clear();
int[] mass;
mass = new int[10];
Random rand = new Random();
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rand.Next(1, 100);
}
void PrintArray(int[] array)
{
    Console.Write("Задан массив вещественных чисел: ");
    int count = array.Length;
    for (int j = 0; j < count; j++)
    {
        Console.Write($"{array[j]}, ");
    } 

}
void MinMax(int[] array)
{
int max = array[0];
int min = array[0];
for (int i = 0; i < mass.Length; i++)
{
if (mass[i] > max) max = mass[i];
if (mass[i] < min) min = mass[i];
}
Console.WriteLine($"Разница между максимальным и минимальным эллементов массива = {max - min}.");
}
PrintArray(mass);
Console.WriteLine();
MinMax(mass);