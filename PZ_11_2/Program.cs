using System;

namespace PZ_11_2
{
 
    struct pz_11_2
    {
    
        public char name;
        public int chislo;

        //метод для вывода информации по текущему экземпляру структуры
        public void Show()
        {
            Console.WriteLine($"Символ -  {name} \nсумма - {chislo}");
        }
    }
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            pz_11_2 obj1, obj2;   // создание экземпляров структур
            pz_11_2* allobj;      // создание указателя на структуру

            allobj = &obj1;  

            // обращение к полям 
            allobj->name = 'A';
            allobj->chislo = 1000;

            allobj->Show();     // вызов метода структуры 

            allobj = &obj2;   // новое значение

            // обращение к полям структуры 
            allobj->name = 'B';
            allobj->chislo = 500;

            allobj->Show();     // вызов метода 

          

          
                                
        }
    }
   
}