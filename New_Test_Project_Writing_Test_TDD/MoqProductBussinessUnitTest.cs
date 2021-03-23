using System;
using Moq;
using NUnit.Framework;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Writing_Test_TDD
{
    using Writing_Test_TDD;
    [TestFixture]
    //[TestClass]
    public class MoqProductBussinessUnitTest
    {
        [Test]
        //[TestMethod]
        public void ItShouldCallCreateProduct()
        {
            //arrange
            var mockDataAccess = new Mock<ITypeProduct>();
            mockDataAccess.Setup(a => a.CreateProduct(It.IsAny<Product>())).Returns(true);
            var productBusiness = new ProductBusinessFactory(mockDataAccess.Object);

            //act
            productBusiness.CreateProduct(new Product());

            //assert
            mockDataAccess.Verify(a => a.CreateProduct(It.IsAny<Product>()), Times.Once());
        }
    }
}
