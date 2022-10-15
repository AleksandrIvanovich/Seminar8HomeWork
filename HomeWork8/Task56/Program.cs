/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
*/

int GetNumber(string message)
{
  Console.WriteLine(message);
  int number = int.Parse(Console.ReadLine() ?? "");
  return number;
}
int m = GetNumber("Введите число (кличество столбцов)");
int n = GetNumber("Введите число (кличество срок)");

int[,] matrix = new int[m, n];
int[,] summMatrix = new int[m, n]; 

Console.WriteLine("Матрица:");  
Random ran = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = ran.Next(1, 10);
            summMatrix[i, j] = matrix[i, j];
            Console.Write("{0}\t", matrix[i, j]);
        }
    Console.WriteLine();
    }

int[] temp = new int[n];
 
Console.WriteLine("\nСтроки матрицы сортированны по убыванию: ");

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            temp[j] = summMatrix[i, j];
            int summ = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                
                summ = summ + temp[k];
                Console.Write("{0}\t", summ);
            }
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int maxNum = matrix[]
            
        }    


    Console.WriteLine();
}
