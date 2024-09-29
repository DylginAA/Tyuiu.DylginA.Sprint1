using Tyuiu.DylginA.Sprint1.Task3.V5.Lib;
namespace Tyuiu.DylginA.Sprint1.Task3.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1");
            Console.WriteLine("* Тема: #1.3 Операторы составного присваивания");
            Console.WriteLine("* Задание #3");
            Console.WriteLine("* Вариант #5");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:");
            Console.WriteLine("* Написать программу вычисления расстояния между населенными пунктами, изображенными на карте.");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Масштаб карты (количество км. в одном см.) -> 120");
            Console.WriteLine("Расстояние между точками, изображающими населенные пункты (см) -> 3.5");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine("Расстояние между населенными пунктами:" + ds.DistanceLength(3.5, 120));
        }
    }
}
