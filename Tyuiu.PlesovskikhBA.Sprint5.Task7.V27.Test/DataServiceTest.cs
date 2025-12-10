using System.IO;
using Tyuiu.PlesovskikhBA.Sprint5.Task7.V27.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint5.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V27.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            Assert.IsTrue(exists);
        }
    }
}