using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PlesovskikhBA.Sprint5.Task1.V29.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint5.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Administrator\source\repos\Tyuiu.PlesovskikhBA.Sprint5\Tyuiu.PlesovskikhBA.Sprint5.Task1.V29\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}