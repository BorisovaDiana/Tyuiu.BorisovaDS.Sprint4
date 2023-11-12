using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorisovaDS.Sprint4.Task7.V14.Lib;

namespace Tyuiu.BorisovaDS.Sprint4.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 4;
            string value = "458712659137";
            int res = ds.Calculate(n, m, value);
            int wait = 38;
            Assert.AreEqual(wait, res);
        }
    }
}
