using Tyuiu.DylginA.Sprint1.Task1.V5.Lib;
namespace Tyuiu.DylginA.Sprint1.Task1.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1");
            Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях");
            Console.WriteLine("* Задание #0");
            Console.WriteLine("* Вариант #20");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, ");
            Console.WriteLine("* вычисляет результат по формуле (5+(x*y/3)) b печатает его на экране.");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            double x, y;
            Console.WriteLine("Введите х:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("(5+(x*y/3) = " + ds.Calculate(x,y));
        }
    }
}
