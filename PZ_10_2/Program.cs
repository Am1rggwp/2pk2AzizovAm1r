using System;
struct Pupil
{
    public string name;
    public int[] Datab;
    public string zodiac;
    public Pupil(string n, string group, int[] ses) // создание переменных для дальнейшего использования
    {
        Datab = ses;
        name = n;
        zodiac = group;
    }
    public void Show()
    {
        Console.WriteLine($"Человек {name}\nЗодиак {zodiac}  \nДата рождения: ");
        for (int i = 0; i < Datab.Length; i++)// цикл для коректоного ввода даты дня рождения
        {
            Console.Write(Datab[i]);
            if (i != Datab.Length - 1)
                Console.Write(".");
        }
        Console.WriteLine();
    }
}
internal class Program
{
    static void Main()
    {
        string data;
        string[] data1;
        Pupil[] BOOK = new Pupil[8]; // указываем сколько человек нужно ввести
        for (int i = 0; i < BOOK.Length; i++) // создаём цикл для ввода переменных
        {
            Console.Write($"Введите Имя Персонажа {i + 1}: ");
            BOOK[i].name = Console.ReadLine();
            Console.Write("Введите Его Знак: ");
            BOOK[i].zodiac = Console.ReadLine();
            Console.Write("Введите Дату рождения в формате гг.мм.дд: ");
            data = Console.ReadLine();
            BOOK[i].Datab = new int[3]; // масив с датой где указанно три значения 
            data1 = data.Split('.');
            for (int j = 0; j < 3; j++) BOOK[i].Datab[j] = Convert.ToInt32(data1[j]); // цикл для конвертации строки в целочисленные
            Console.WriteLine();
        }
        //for (int i = 0; i < BOOK.Length; i++) // цикл для того чтобы ввел все данные с book
        //{
        //    Console.WriteLine("-------------------");
        //    BOOK[i].Show();
        //    Console.WriteLine("-------------------");
        //}
        Console.WriteLine("Введите имя для поиска: ");
        string peremen = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < BOOK.Length; i++) 
        {
            if (BOOK[i].name == peremen) //условие для поиска данных по имени 
            {
                Console.WriteLine("-------------------\n-------------------");
                BOOK[i].Show();
                count++;
                Console.WriteLine("-------------------\n-------------------");
            }
        }
        if (count == 0) Console.WriteLine("Error");

    }
}
