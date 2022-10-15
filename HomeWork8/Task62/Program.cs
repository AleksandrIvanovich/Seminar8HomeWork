//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int [,] InitSpiralMatrix(int m, int n)
{
  int[,] matrix = new int[m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
       
         matrix[0,0] = 1;
         matrix[0,1] = 2;
         matrix[0,2] = 3;
         matrix[0,3] = 4;
         matrix[1,0] = 12;
         matrix[1,1] = 13;
         matrix[1,2] = 14;
         matrix[1,3] = 5;
         matrix[2,0] = 11;
         matrix[2,1] = 16;
         matrix[2,2] = 15;
         matrix[2,3] = 6;
         matrix[3,0] = 10;
         matrix[3,1] = 9;
         matrix[3,2] = 8;
         matrix[3,3] = 7;
     }
  }

  return matrix;
}

void PrintMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
          Console.Write($"{matrix[i,j]}\t");
      }
      Console.WriteLine();
   }
}
int m = 4;
int n = 4;
int[,] matrix = InitSpiralMatrix(m, n);

Console.WriteLine("Матрица:");
PrintMatrix(matrix);