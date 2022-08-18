//  Заполните спирально массив 4 на 4.

int[,] GetSpiral(int[,] inArray)
{
    int a = 1;
int i = 0;
int j = 0;

while (a <= inArray.GetLength(0) * inArray.GetLength(1))
{
  inArray[i, j] = a;
  a++;
  if (i <= j + 1 && i + j < inArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= inArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > inArray.GetLength(1) - 1)
    j--;
  else
    i--;
}
    return inArray;
}



int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

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
GetSpiral(array);
PrintArray(array);