using Tyuiu.DylginA.Sprint1.Task4.V5.Lib;
namespace Tyuiu.DylginA.Sprint1.Task4.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1");
            Console.WriteLine("* Тема: #1.4 Class Math");
            Console.WriteLine("* Задание #3");
            Console.WriteLine("* Вариант #5");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            double x, y;
            Console.WriteLine("Введите X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат решенного уравнения равен: " + ds.Calculate(x,y));
        }
    }
}
