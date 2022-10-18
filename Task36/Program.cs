/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
 */
Console.Clear();
Console.Write("Массив из случайных чисел: ");
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int j = 0; j < count; j++)
    {
        Console.Write($"{array[j]}, ");
    } 

}
void Sum (int[] array)
{
    int count = array.Length;
    int i = 0;
    int res = 0;
    while (i < count)
    {
    if (array[i] == array[1] || array[i] == array[3])
    {
        res += array[i];
    }
    i++;
    }
    Console.Write($"Сумма элементов, стоящих на нечетных позициях: {res}");
} 

int[] mass = new int[4];
Random rand = new Random();
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rand.Next(1, 100);
}
PrintArray(mass);
Console.WriteLine();
Sum(mass);
