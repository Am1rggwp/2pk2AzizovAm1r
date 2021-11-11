using System;

namespace PZ_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] str = new string[3][];
            str[0] = new string[3] { "Зеленый", "кустарный", "дом" };
            str[1] = new string[3] { "big", "red", "apple" };
            str[2] = new string[3] { "маленький", "yellow", "грибочек" };
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write(str[y][x] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
