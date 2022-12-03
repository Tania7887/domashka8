// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов.


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
int[] SumRowInArray(int[,] BiArray) //строка[,] = индекс[]
{
    int[] result = new int[BiArray.GetLength(0)];
    int k = 0;
    for (int i = 0; i < BiArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < BiArray.GetLength(1); j++)
        {
            sum += BiArray[i, j];
        }
        result[k++] = sum;
    }
    return result;
}
void FindRowMinSum(int[] arr)
{
    int minSum = arr[0];
    int rowMinSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minSum)
        {
            minSum = arr[i];
            rowMinSum = i;
        }
    }
    Console.WriteLine($"Min sum elements in string: {minSum}. ");
    Console.WriteLine($"String: {rowMinSum + 1}. ");
}
Console.Clear();
Console.Write("Enter the number of rows in the array: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns in the array: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, columns, 0, 20);
PrintArray(array);
int[] newMass = SumRowInArray(array);
Console.WriteLine();
FindRowMinSum(newMass);
