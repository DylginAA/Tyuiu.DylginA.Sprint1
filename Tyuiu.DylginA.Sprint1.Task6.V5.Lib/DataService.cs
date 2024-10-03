using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DylginA.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            foreach (var word in value.Split(' '))
                if (word == new string(word.Reverse().ToArray()))Console.WriteLine(word);
            return value;
        }
    }
}
