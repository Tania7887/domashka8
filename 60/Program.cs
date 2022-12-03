//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2


void PrintMatrix(int[,,] matrix)
{
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int z = 0; z < matrix.GetLength(1); z++)
                Console.Write($"{matrix[x, y, z]}({x},{y},{z})   ");
            Console.WriteLine();
        }
    }
}

void MatrixNew(int[,,] matrix)
{
    int[] point = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
  int  number;
  for (int i = 0; i < point.GetLength(0); i++)
  {
    point[i] = new Random().Next(10, 100);
    number = point[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (point[i] == point[j])
        {
          point[i] = new Random().Next(10, 99);
          j = 0;
          number = point[i];
        }
          number = point[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < matrix.GetLength(0); x++)
  {
    for (int y = 0; y < matrix.GetLength(1); y++)
    {
      for (int z = 0; z < matrix.GetLength(2); z++)
      {
        matrix[x, y, z] = point[count];
        count++;
      }
    }
  }
}

int[,,] matrix = new int[2, 2, 2];
MatrixNew(matrix);
Console.WriteLine($"3D array:");
PrintMatrix(matrix);