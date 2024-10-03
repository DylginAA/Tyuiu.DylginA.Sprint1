using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DylginA.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {

            foreach (string word in value.Split(' '))
            {
                string revers = new string(word.Reverse().ToArray());
                if (word == revers)
                {
                    value = word;
                    Console.WriteLine(word);
                }
            }
            return value;
        }
    }
}
