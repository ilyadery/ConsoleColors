using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, y; 
            String Str; // имя переменной, в которой хранится совокупность символов
            Console.BackgroundColor = ConsoleColor.White; // для изменения цвета консоли в области текста
            Console.ForegroundColor = ConsoleColor.Green; // цвет букв
            Console.Clear(); // для изменения цвета всего окна

            Console.Write("Введите первое число: "); Str = Console.ReadLine();

            a = Convert.ToInt16(Str); 

            Console.Write("Введите второе число: "); Str = Console.ReadLine();

            b = Convert.ToInt16(Str); y = a + b;
            Str = y.ToString("d");

            Console.Write("Результат равен: "); Console.Write(Str);

            Console.Write("Для завершения работы приложения нажмите <Enter>"); Console.Read();

        }
    }
}
