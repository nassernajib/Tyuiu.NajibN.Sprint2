using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NajibN.Sprint2.Task7.V2.Lib;
namespace Tyuiu.NajibN.Sprint2.Task7.V2.Test
{
    [TestClass]
    public class Tests
    {
        private readonly bool Is;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            Assert.That(ds.CheckDotInShadedArea(1, -0.5), Is.Equals(false));
        }

        [Test]
        public void Test2()
        {
            DataService ds = new DataService();
            Assert.That(ds.CheckDotInShadedArea(0.5, -0.5), Is.Equals(true));
        }
 
        }
}
