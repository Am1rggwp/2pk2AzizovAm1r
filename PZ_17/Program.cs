using System;

namespace PZ_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();//считываем строку
            double a = CountSpace(s);
            Console.WriteLine("Пробелов - " + a + "%");//выводим значение

        }
        static int CountSpace(string str)// сам метод
        {
            int result = 0;//счетчик пробелов
            char[] c = str.ToCharArray();
            for (int i = 0; i < c.Length; i++)//проверяем каждый символ строки соответсвует ли пробелу
            {
                if (c[i] == ' ')
                {
                    result++;
                }
            }
            return result * 100 / c.Length;//формула расчета в процентном соотношении
        }

    }

}
