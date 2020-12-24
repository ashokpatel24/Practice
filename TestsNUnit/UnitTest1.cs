using Domain;
using NUnit.Framework;

namespace TestsNUnit
{
    public class Tests
    {
        Class1 class1;

        [SetUp]
        public void Setup()
        {
            class1 = new Class1();
        }

        [Test]
        public void Test1()
        {
            var total = class1.Sum(1,1);

            Assert.AreEqual(2, total);
        }
    }
}