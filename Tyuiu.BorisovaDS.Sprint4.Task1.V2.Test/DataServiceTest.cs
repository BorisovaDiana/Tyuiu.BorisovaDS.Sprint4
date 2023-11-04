using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorisovaDS.Sprint4.Task1.V2.Lib;

namespace Tyuiu.BorisovaDS.Sprint4.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            Assert.AreEqual(34, ds.Calculate(new int[] { 1, 7, 2, 2, 6, 2, 3, 2, 3, 5, 7, 7, 1, 2 }));
        }
    }
}
