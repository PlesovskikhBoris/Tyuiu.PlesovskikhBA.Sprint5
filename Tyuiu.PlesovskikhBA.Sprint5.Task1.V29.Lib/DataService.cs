using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PlesovskikhBA.Sprint5.Task1.V29.Lib
{
    public class DataService : ISprint5Task1V29
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string str;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((Math.Sin(x) / (x + 1.2)) + Math.Cos(x) * 7 * x - 2), 2);
                if ((x + 1.2) == 0)
                {
                    y = 0;
                }
                str = Convert.ToString(y);
                if (x != stopValue)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
            }
            return path;
        }
    }
}