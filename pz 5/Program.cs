using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1:");
            int a;
            for (a = 0; a <= 90; a += 5)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();


            Console.WriteLine("Задание №2:");
            char simvol;
            int c = 1;
            for (simvol = 'b'; c < 6; simvol++, c++)
            {
                Console.Write(simvol);
            }


            Console.WriteLine("Задание №3:");
            for (int m = 0; m < 5; m++)
            {
                for (int n = 0; n < 4; n++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Задание №4:");
            for (int x = 0; x <= 100; x++)
            {
                if (x % 7 == 0)
                {
                    Console.Write(x + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Задание №5:");
            for (int i = 1, j = 40; (i - j) != 20; i++, j--)
            {
                Console.WriteLine("{0} {1}", i, j);
            }
            Console.WriteLine();
        }
    }
}
