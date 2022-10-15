int n = 4;
            int[,] a = new int[n, n];
            int[,] b = new int[n, n]; //массив для сортировки по строкам
            int[,] c = new int[n, n]; //массив для сортировки по столбцам
    Console.WriteLine("Матрица:");  
            Random ran = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = ran.Next(1, 10);
                    b[i, j] = a[i, j];
                    c[i, j] = a[i, j];
                    Console.Write("{0}\t", a[i, j]);
                }
                Console.WriteLine();
            }
            int[] temp = new int[n];
 
            Console.WriteLine("\nСтроки сортированны по убыванию: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    temp[j] = b[i, j];
                Array.Sort(temp);
                Array.Reverse(temp);
                for (int k = 0; k < n; k++)
                {
                    b[i, k] = temp[k];
                    Console.Write("{0}\t", b[i, k]);
                }
                Console.WriteLine();
            }
