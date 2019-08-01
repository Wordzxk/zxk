using NUnit.Framework;
using System;

namespace Word
{
    //设置为最先执行可有可无
    [TestFixture(Category = "One")]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //销毁测试环境
        [TearDown]
        public void TearDown()
        {

        }

        [Test]
        public void ArrayTest()
        {
            int[] array = {1,3,4,6,11,22,33 };

            Assert.That(array.Length, Is.EqualTo(7));
            Assert.That(array.Length, Is.GreaterThanOrEqualTo(7));

            Assert.Pass();
        }
        [Test]
        public void TestOne()
        {
            int[] array = { 1, 3, 4, 6, 11, 22, 33 };
            Assert.That(array, Is.Not.Null);
            Assert.That(array.Length, Is.Not.Null);
        }
        [Test]
        public void TestTwo()
        {
           
            Assert.That("Hello, Word", Is.Not.Empty.Or.Null);
            Assert.That("Hello".StartsWith("Hello"), Is.True);
            Assert.That("Word", Is.Not.Empty.Or.Null);
        }
        [Test]
        public void Testthress()
        {
            Assert.That("", Is.Empty);
        }
        [Test]
        public void Testfour()
        {
            
            Assert.That(6 > 22, Is.False);
            Assert.That(11 > 1, Is.True);
        }
        [Test]
        public void Testfive()
        {
            int[] array = { 1, 3, 4, 6, 11, 22, 33 };

            Assert.That(array, Is.EquivalentTo(new int[] { 1, 3, 4, 6, 11, 22, 33 }));

        }

    }
    
   public class TestTwo
    {
        [SetUp]
        public void One()
        {
           
        }
       
    }
}