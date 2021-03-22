using System;
using static Writing_Test_TDD.Program;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Writing_Test_TDD
{
    using Writing_Test_TDD;    

    [TestClass] //it is for Microsoft.VisualStudio.TestTools.UnitTesting
    [TestFixture]
    public class MathUnitTest
    {
        static object[] _avgData1 = 
        {
            new object[]{100, 200, 300},
            new object[]{1000, 800, 500}
        };

        static object[] _avgData2;

        int a = 10;
        int b = 20;
        int c = 30;
        //int a;
        //int b;
        //int c;

        [SetUp] //???????????????????
        public void SetUp_1()
        {
            _avgData2 = new object[]
            {
                new object[]{50, 20, 40},
                new object[]{10, 80, 60}
            };
            //a = 10;
            //b = 20;
            //c = 30;
        }

        public static object[] SetUp_2()
        {
            object[] _avgData3 = 
            {
                new object[] {1, 6, 8},
                new object[]{2, 4, 3}
            };
            return _avgData3;
        }

        [TestMethod] //it is for Microsoft.VisualStudio.TestTools.UnitTesting
        [Test]
        public void TestMin()
        {
            //Arrange
            var a = 10;
            var result = 4;
            //Act
            int min = Program.Min(a, 4, 5);
            //Assert
            Assert.AreEqual(result, min);
        }
        //int a, int b, int c

        [TestCase(2, 12, 10)]
        [TestCase(6, 18, 22)]
        [TestCaseSource(nameof(_avgData1))]
        [TestCaseSource(nameof(_avgData2))]
        [TestCaseSource(nameof(SetUp_1))]
        [TestCaseSource(nameof(SetUp_2))]        
        public void TestAvg_1(int a, int b, int c)
        {
            float avg = Program.Avg(a, b, c);
            Assert.AreEqual(((float)a + b + c) / 3, avg);
        }

        [TestMethod, SetUp]
        [Test]
        public void TestAvg_2()
        {
            float avg = Program.Avg(a, b, c);
            Assert.AreEqual(((float)a + b + c) / 3, avg);
        }

        [TestMethod]
        [TestCase(10, 2)]
        [TestCase(10, 5)]
        [TestCase(10, 0)]
        [ExpectedException(typeof(DivideByZeroException),
            "We can't divison on zero")]
        public void DivideThrowsWhenDivizorIsZero(int arg1, int arg2)
        {
            // act
            float result = Div(arg1, arg2);
            // assert
            Assert.AreEqual(arg1 / arg2, result);
            //Assert.Throws;
        }
        
        //[TearDown] - it is for execute last, after a test
        //public void TearDown()
        //{
        //}
    }
}
