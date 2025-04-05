using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NajibN.Sprint2.Task6.V6.Lib;
namespace Tyuiu.NajibN.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("шестерка пик", ds.FindCardNameAndValue(1, 6));
        }
        }
    }
