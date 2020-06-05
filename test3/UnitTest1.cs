using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace test3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            unitTest_3.Program.ReadWrite(@"D:/1.txt", @"D:/2.txt");

            //act
            List<string> lines = File.ReadAllLines(@"D:/2.txt").ToList<string>();
            List<string> lines2 = File.ReadAllLines(@"D:/3.txt").ToList<string>();

            string l1 = lines.ToString();
            string l2 = lines.ToString();


            //assert
            Assert.AreEqual(l1, l2);
        }
    }
}
