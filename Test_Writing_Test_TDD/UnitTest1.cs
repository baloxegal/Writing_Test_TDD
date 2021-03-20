using System;
using NUnit.Framework;
using Moq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Writing_Test_TDD
{
    using Writing_Test_TDD;
    
    //[TestClass]
    [TestFixture]
    public class UnitTest1
    {
        //[SetUp] - it is for intialization data for test
        //public void SetUp()
        //{
        //}

        //static object[] avgData =
        //{
        //    new object[]{100, 200, 300},
        //    new object[]{1000, 800, 500},
        //};

        //[TestMethod]
        ////[Test]

        [TestCase]
        public void TestMin()
        {
            //Arrange
            int min;
            //Act
            min = Program.Min(3, 4, 5);
            //Assert
            Assert.AreEqual(3, min);
        }

        [TestCase]
        //[TestCase(2,12,10)] //TestCaseAttributes
        //[TestCase(6,18,22)]
        //[TestMethod(2,12,10)] TestCaseSourceAttributes
        public void TestAvg()
        {
            float avg;
            avg = Program.Avg(10, 8, 6);
            Assert.AreEqual(8.0, avg);
        }

        //MOQ
        //[TestMethod]
        //public void ItShouldCallCreateProduct()
        //{
        //    //arrange
        //    var mockDataAccess = new Mock<IRepository>();
        //    mockDataAccess.Setup(m = > m.CreateProduct(It.IsAny<Product>)).Returns(true);
        //    var productBusiness = new ProductBusiness(mockDataAccess.Object);

        //    //act
        //    productBusiness.CreateProduct(new Product());

        //    //assert
        //    mockDataAccess.Verify(m = > m.CreateProduct(It.IsAny<Product>), Times.Once())
        //}


        //[TearDown] - it is for execute last, after a test
        //public void TearDown()
        //{
        //}
    }
}
