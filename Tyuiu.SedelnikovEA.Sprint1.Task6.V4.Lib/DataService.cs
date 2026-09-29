using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SedelnikovEA.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string MoveLetterToStart(string value)
        {
            string[] words = value.Split(' ');
            string result = "";
            foreach (string word in words)
            {
                string transformedWord;
                char last = word[word.Length - 1];
                string rest = word.Substring(0, word.Length - 1);
                transformedWord = last + rest;

                result += transformedWord + " ";
            }
            return result.Substring(0, result.Length - 1);
        }
    }
}
