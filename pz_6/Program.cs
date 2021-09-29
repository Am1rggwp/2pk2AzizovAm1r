using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите пробег в первый день");
            Double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите день");
            int y = Convert.ToInt32(Console.ReadLine());
            do
            {
                x += x * 0.1;
                //Console.Write("дней:" + y);
                y++;
            }
            while (y == 20);
            Console.WriteLine("Его пробег за этот день: ");
            Console.Write(x);



        }
    }
}
