using NUnit.Framework;
using Kursach;
using System.Collections.Generic;

namespace TestProject_1
{
    public class Tests
    {
        SHifr SH;

        [SetUp]
        public void Setup()
        {
            SH = new SHifr();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}