using System;
//using NUnit.Framework;
using Moq
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Writing_Test_TDD
{
    using Writing_Test_TDD;
    [TestClass]
    //[TestFixture] - it is denotes this class is for test
    public class UnitTest1
    {

        //[SetUp] - it is for intialization data for test
        //public void SetUp()
        //{
        //}

        static object[] AvgData =
        {
            new object[]{100, 200, 300},
            new object[]{1000, 800, 500},
        };

        [TestMethod]
        //[TestCase]
        //[Test]- it is denotes this method is for test
        public void TestMin()
        {
            //Arrange
            int min;
            //Act
            min = Program.Min(3, 4, 5);
            //Assert
            Assert.AreEqual(3, min);
        }
        [TestMethod]
        //[TestMethod(2,12,10)] TestCaseAttributes
        //[TestMethod(6,18,22)]
        //[TestMethod(2,12,10)] TestCaseSourceAttributes
        public void TestAvg()
        {
            float avg;
            avg = Program.Avg(10, 3, 6);
            Assert.AreEqual(5, avg);
        }

        //MOQ
        [TestMethod]
        public void ItShouldCallCreateProduct()
        {

            //arrange
            var mockDataAccess = new Mock<IReposio>();
            mockDataAccess.Setup(m = > m.CreateProduct(It.IsAny<Product>)).Returns(true);
            var productBusiness = new ProductBusiness(mockDataAccess.Object);

            //act
            productBusiness.CreateProduct(new Product());

            //assert
            mockDataAccess.Verify(m = > m.CreateProduct(It.IsAny<Product>), Times.Once())
 }


        //[TearDown] - it is for execute last, after a test
        //public void TearDown()
        //{
        //}
    }
}
