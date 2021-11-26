using System;
using System.IO;

namespace PZ_16
{
    class Program
    {
        static void GetSquareSumm(int m, int n, out int summ)
        {
            summ = 0;
            if (n == m)// Проверяем условием на равность чилес
            {
                int c = 0;
                for (int i = 1; i <= m; i++)
                {
                    if (m % i == 0)
                        c++;
                }
                if (c == 2)
                {
                    summ = m * m;
                    return;
                }
                else
                {
                    summ = 0;
                    return;
                }
            }

            for (; m < n; m++)// Если числа не совподают то происходит цикл на простоту чисел и сумирование квадратных чисед 
            {
                int count = 0;
                for (int i = 1; i <= m; i++)
                {
                    if (m % i == 0)
                        count++;
                }
                if (count == 2)
                    summ += m * m;
            }
        }
        static void Main()
        {
            Console.WriteLine("Введите диапазон:");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int res;
            GetSquareSumm(m, n, out res);
            Console.WriteLine( "результат"+res);//вывод резельтата
        }
    }
}