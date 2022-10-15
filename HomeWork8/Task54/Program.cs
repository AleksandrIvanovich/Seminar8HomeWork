// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.

int GetNumber(string message)
{
  Console.WriteLine(message);
  int number = int.Parse(Console.ReadLine() ?? "");
  return number;
}
int m = GetNumber("Введите число (кличество столбцов)");
int n = GetNumber("Введите число (кличество срок)");

int[,] matrix = new int[m, n];
int[,] sortMatrix = new int[m, n]; 

Console.WriteLine("Матрица:");  
Random ran = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = ran.Next(1, 10);
            sortMatrix[i, j] = matrix[i, j];
            Console.Write("{0}\t", matrix[i, j]);
        }
    Console.WriteLine();
    }

int[] temp = new int[n];
 
Console.WriteLine("\nСтроки матрицы сортированны по убыванию: ");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            temp[j] = sortMatrix[i, j];
            Array.Sort(temp);
            Array.Reverse(temp);
            for (int k = 0; k < n; k++)
            {
                sortMatrix[i, k] = temp[k];
                Console.Write("{0}\t", sortMatrix[i,k]);
            }
    Console.WriteLine();
}