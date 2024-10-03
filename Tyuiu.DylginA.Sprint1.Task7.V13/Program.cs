using Tyuiu.DylginA.Sprint1.Task7.V13.Lib;
namespace Tyuiu.DylginA.Sprint1.Task7.V13
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
            Console.WriteLine("* Задание #6");
            Console.WriteLine("* Вариант #13");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным значениям данных, вводимых пользователем. Ответ округлите до 3 знаков после запятой. ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");

            double x;
            double y;
            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();

          
        }
    }
}
