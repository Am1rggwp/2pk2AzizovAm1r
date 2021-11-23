using System;
using System.IO;

namespace PZ_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Text.txt";//Путь к файлу
            if (!File.Exists(path)) // Проверяем на существование
            {
                // Создаём и записывам в этот файл
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }
            Console.Write("Введите число длы вырезки: ");
            int K = int.Parse(Console.ReadLine());
            string str = "";
            using (StreamReader sr = File.OpenText(path))// Открываем и читаем файл
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    K--; //Для простоты, чтобы не создавать несколько перемен, мы уменьшаем число
                    if (K == 0) continue; //Если оно равно 0 - то это та позиция, которую надо вырезать
                    str += s + "\n";
                }
            }
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(str);
            }
        }
    }
}
