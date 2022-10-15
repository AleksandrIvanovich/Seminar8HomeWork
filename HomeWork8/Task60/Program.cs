/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/
int GetNumber(string message)
{
  Console.WriteLine(message);
  int number = int.Parse(Console.ReadLine() ?? "");
  return number;
}

int [,,] Init3DMatrix(int y, int x, int z)
{
  int[,,] matrix = new int[y, x, z];
  Random rnd = new Random();
 
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
        matrix[i, j, k] = rnd.Next(10, 100);
        }
     }
  }
  return matrix;
}
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
        Console.WriteLine();
        }
    }
}
int x = GetNumber("Введите число (кличество столбцов)");
int y = GetNumber("Введите число (кличество срок)");
int z = GetNumber("Введите число (высота массива)");
int[,,] matrix = Init3DMatrix(x, y, z);
Console.WriteLine("3D матрица :");
PrintMatrix(matrix);