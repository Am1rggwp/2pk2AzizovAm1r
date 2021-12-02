using System;

namespace PZ_18
{
    class Program
    {
        static int Arifm(int n, int a, int b)
        {
            if (n < 1) return 0;// ставим условия если n < 1 то возрощаем 0
            else if (n == 1) return a;// ставим условия если n < 1 то возрощаем 0
            return Arifm(n - 1, a + b, b);// формула арифметической прогрессии
        }
        static double Geom(int n, double b1, double q)
        {
            if (n < 1) return 0;// описанно в 1 задании
            else if (n == 1) return b1;
            return Geom(n - 1, b1 * q, q);// формула геометрической прогрессии
        }
        static void numbers(int a, int b)
        {
            if (a < b)//условие если a<b 
            {
                Console.Write(a + " ");
                numbers(a + 1, b);// если да то выполняется формула возростания
            }
            else if (b < a)// условие если a < b в противном случии
            {
                Console.Write(a + " ");
                numbers(a - 1, b);// вы полняется формула убывания
            }
            else if (b == a) Console.WriteLine(b);// если равны 
            else
            {
                Console.Write("");//что выводится путсая строка 
            }
        }
        static double Power(double a, int b)
        {
            if (b == 0) return a;//находим степень числа если b = 0 то возрощаем значение а
            else // в противном случаии 
            {
                return Power(Math.Pow(a, b), b - 1);// считаем по формуле и находим 
            }
        }


        static void Main(string[] args)// метод для вывода ответов всех задач
        {
            Console.WriteLine("№1 Ариф. прогресия:" + Arifm(7, 2, 6));
            Console.WriteLine("№2 Геом. прогресия:" + Geom(3, 2, 0.5));
            Console.WriteLine("№3");
            numbers(50, 200);
            Console.WriteLine('\n' + "№5 " + Power(2, 6));

        }
    }
}
    

