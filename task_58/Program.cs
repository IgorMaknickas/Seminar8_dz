//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void SumMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] sumMatrix, int rows, int colomns )
{
    for (int i = 0; i < sumMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < sumMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secondMartrix[k, j];
            }
            sumMatrix[i, j]= sum;
        }
    }
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

Console.Write("Введите количество строк матриц: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов матриц: ");
int columns = int.Parse(Console.ReadLine());

int[,] firstMartrix = GetArray(rows, columns, 0, 10);
PrintArray(firstMartrix);
Console.WriteLine();

int[,] secondMartrix = GetArray(rows, columns, 0, 10);
PrintArray(secondMartrix);
Console.WriteLine();

int[,] sumMatrix = new int[rows, columns];
SumMatrix(firstMartrix, secondMartrix, sumMatrix, rows, columns);
Console.WriteLine($"произведение двух матриц:");
PrintArray(sumMatrix);
