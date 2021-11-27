using System;
using System.IO;

namespace PZ_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Text.txt";//путь к файлу
            string[] str = File.ReadAllLines(path);//создаем масив который будет читать файл
            for (int i = 0; i < str.Length; i++)//цыкл который прогонятет текст
            {
                char[] ch = str[i].ToCharArray();//массив с одним сиволом
                if (ch[0] == ch[ch.Length - 1]) Console.WriteLine(str[i]);//При нахождении строчки с одним и тем же сиволом(в начале и в конце) выводит на экран 
                Console.ReadLine();
            }
        }   
    }
}
