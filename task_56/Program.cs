// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей
// суммой элементов.

int GetSum(int[,] array, int i)
{
    int summa = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        summa += array[i, j];
    }
    return summa;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();

int mSumma = 0;
int summa = GetSum(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int newSumma = GetSum(array, i);
    if (summa > newSumma)
    {
        summa = newSumma;
       mSumma = i;
    }
}

Console.WriteLine($"\n{mSumma + 1} - строкa с минимальной суммой ({summa})");

PrintArray(array);
