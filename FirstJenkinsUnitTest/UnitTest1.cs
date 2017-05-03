using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirstJenkinsUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int sum = 0;
            
            for(int i =0;i<10;i++)
            {
                sum = sum + i;
                Console.WriteLine("sum = {0}", sum);
            }
        }
    }
}
