using System;
using NUnit;
using Moq;
using NUnit.Framework;
//using Assert = NUnit.Framework.Assert;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace New_Test_Project_Writing_Test_TDD
{
    using Writing_Test_TDD;
    

    //[TestClass]
    [TestFixture]
    public class MathFixture
    {
        //[TestMethod]
        [Test]
        public void TestMinFixture()
        {
            //Arrange
            var a = 10;
            var result = 4;
            //Act
            int min = Program.Min(a, 4, 5);
            //Assert
            Assert.AreEqual(result, min);
        }

        [TestCase(2, 12, 10)]
        [TestCase(6, 18, 22)]        
        public void TestAvg_1Fixture(int a, int b, int c)
        {
            float avg = Program.Avg(a, b, c);
            Assert.AreEqual(((float)a + b + c) / 3, avg);
        }

        static object[] _avgData1 =
        {
            new object[]{100, 200, 300},
            new object[]{1000, 800, 500}
        };

        //[Test, TestCaseSource("_avgData1")]
        [TestCaseSource(nameof(_avgData1))]        
        public void TestAvg_2Fixture(int a, int b, int c)
        {
            float avg = Program.Avg(a, b, c);
            Assert.AreEqual(((float)a + b + c) / 3, avg);
        }

        public static object[] SetUp_1()
        {
            object[] _avgData2 =
            {
                new object[] {1, 6, 8},
                new object[]{2, 4, 3}
            };
            return _avgData2;
        }

        [TestCaseSource(nameof(SetUp_1))]
        public void TestAvg_3Fixture(int a, int b, int c)
        {
            float avg = Program.Avg(a, b, c);
            Assert.AreEqual(((float)a + b + c) / 3, avg);
        }

        int a = 10;
        int b = 20;
        int c = 30;

        [Test]        
        public void TestAvg_4Fixture()
        {
            float avg = Program.Avg(a, b, c);
            Assert.AreEqual(((float)a + b + c) / 3, avg);
        }

        static object[] _avgData3;

        [SetUp]
        public void SetUp_2()
        {
            _avgData3 = new object[]
            {
                new object[]{50, 20, 40},
                new object[]{10, 80, 60}
            };
        }

        int d;
        int e;
        int f;

        [SetUp]
        public void SetUp_3()
        {
            d = 40;
            e = 50;
            f = 60;
        }

        [Test, SetUp]
        public void TestAvg_5Fixture()
        {
            float avg = Program.Avg(d, e, f);
            Assert.AreEqual(50, avg);
        }
        
        public class DivFixture
        {
            [TestCase(10, 2)]
            [TestCase(10, 5)]
            public void TestDivideFixture(int arg1, int arg2)
            {
                // act
                float result = Program.Div(arg1, arg2);
                // assert
                Assert.AreEqual(arg1 / arg2, result);
            }

            //[ExpectedException(typeof(DivideByZeroException),
            //    "We can't divison on zero")]
            [TestCase(10, 0)]
            public void DivideThrowsWhenDivizorIsZero(int arg1, int arg2)
            {
                //both - act and assert           
                Assert.Throws<DivideByZeroException>(() => Program.Div(arg1, arg2));
            }

            [TearDown] //it is for execute last, after a test
            public void TearDown()
            {
            }
        }
    }
}
