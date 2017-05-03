using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int sum =0;
            sum = sum + 10;
            Console.WriteLine("sum of two nos = {0}", sum);
        }
    }
}
