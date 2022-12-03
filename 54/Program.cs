// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
void SortRowsInArray(int[,] inArray)
{
    for (int k = 0; k < inArray.GetLength(0); k++)
    {
        for (int i = 0; i < inArray.GetLength(1); i++)
        {
            for (int j = i + 1; j < inArray.GetLength(1); j++)
            {
                if (inArray[k, i] < inArray[k, j])
                {
                    int temp = inArray[k, i];
                    inArray[k, i] = inArray[k, j];
                    inArray[k, j] = temp;
                }
            }
        }
    }
}
Console.Clear();
Console.Write("Enter the number of rows in the array: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns in the array: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, columns, 0, 20);
PrintArray(array);
Console.WriteLine();
SortRowsInArray(array);
PrintArray(array);