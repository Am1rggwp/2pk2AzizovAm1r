using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[50];
            int[] B = new int[21];
            Console.WriteLine("массивы А:");
            Random rnd = new Random();// заполняем масив А в диапозоне от -100 до 100
            for (int i = 0; i <= 49; i++)
            {
                A[i] = rnd.Next(-100, 101);
                Console.WriteLine("A[{0}]= {1}",i, A[i]);
            }
            int sum = 0;
            for (int i = 0, j = 0; i < 50; i++)// копируем масивы из А в Б с условием от -10 до 10
            {
                if (A[i] >= -10 && A[i] <= 10)
                {
                    B[j] = A[i];
                    j++;
                    sum += Math.Abs(A[i]);
                }
            }

            Console.WriteLine("Сумма элементов: " + sum);// вывод суммы масива
            Console.WriteLine("массивы B:");
            for (int i = 0; i < B.Length; i++)
                Console.Write(B[i] + " ");


        }
    }
}
