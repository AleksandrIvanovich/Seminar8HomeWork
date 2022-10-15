/*Задача 58: Задайте две матрицы. Напишите программу,
 которая будет находить произведение двух матриц.
 */
int GetNumber(string message)
{
  Console.WriteLine(message);
  int number = int.Parse(Console.ReadLine() ?? "");
  return number;
}

int [,] InitMatrix(int rov, int col)
{
  int[,] matrix = new int[rov,col];
  Random rnd = new Random();
 
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
        matrix[i, j] = rnd.Next(1, 10);
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
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}

int n = GetNumber("Введите число (кличество строк первой и столбцов второй матриц)");
int m = GetNumber("Введите число (кличество столбцов первой матрицы:)");
int a = GetNumber("Введите число (кличество строк второй матрицы:)");

int[,] matrix1 = InitMatrix(m, n);
int[,] matrix2 = InitMatrix(n, a);
Console.WriteLine("Первая матрица:");
PrintMatrix(matrix1);
Console.WriteLine("Вторая матрица:");
PrintMatrix(matrix2);
Console.WriteLine("Произведение первой и второй матриц:");
PrintMatrix(DivMatrix(matrix1, matrix2));
    