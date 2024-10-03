using Tyuiu.DylginA.Sprint1.Task6.V5.Lib;
namespace Tyuiu.DylginA.Sprint1.Task6.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1");
            Console.WriteLine("* Тема: #1.5 Класс Convert");
            Console.WriteLine("* Задание #5");
            Console.WriteLine("* Вариант #5");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать те слова, которые являются симметричными ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("Введите текст:");
            string value = Console.ReadLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CheckSymmetricalWords(value));
        }
    }
}
