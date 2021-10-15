using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {

            char[,] arr = new char[8, 6];
            char simvol = 'a';
            int i, j;
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    arr[i, j] = simvol++;
                    Console.Write(arr[i, j] + " ");


                }
                Console.WriteLine();

            }
            Console.WriteLine();
            for (i = 0; i < 6; i++)
            {
                char a = arr[0, i];
                arr[0, i] = arr[7, i];
                arr[7, i] = a;

            }
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    Console.Write(arr[i, j] + " ");


                }
                Console.WriteLine();

            }


        }
    }

}
