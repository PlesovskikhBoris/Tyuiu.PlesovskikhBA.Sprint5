using System.IO;
using System.Text;
using Tyuiu.PlesovskikhBA.Sprint5.Task4.V6.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint5.Task4.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask4V6.txt";
            Console.WriteLine("Данные находятся в файле : " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
