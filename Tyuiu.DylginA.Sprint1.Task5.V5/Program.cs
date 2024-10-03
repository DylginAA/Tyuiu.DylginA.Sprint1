using Tyuiu.DylginA.Sprint1.Task5.V5.Lib;
namespace Tyuiu.DylginA.Sprint1.Task5.V5
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
            Console.WriteLine("* Присвоить целой переменной d первую цифру из дробной части положительного вещественного числа x ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            double x, y;
            Console.WriteLine("Введите дробное число X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Первая цифра дробной части = " + ds.Calculate(x));
        }
    }
}
