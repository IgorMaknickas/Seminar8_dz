// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.

int[,,] GetArray(int x, int y, int z)
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]} [{i}, {j}, {k}]; ");
            }
            Console.WriteLine();
        }


    }
}

Console.Write("Введите X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите Z: ");
int z = int.Parse(Console.ReadLine());

int[,,] myArray = GetArray(x, y, z);
PrintArray(myArray);
