using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PlesovskikhBA.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in words)
                    {
                        if (word.Length == 6)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }

    }
}