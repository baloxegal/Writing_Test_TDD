using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using NUnit.Framework;

namespace Test_Writing_Test_TDD
{
    using Writing_Test_TDD;

    [TestFixture]    
    class MoqProductFactoryTest
    {
        private Mock<INotifyProductCreation> _notifyProductCreationMock;

        [SetUp]
        public void SetUp()
        {
            _notifyProductCreationMock = new Mock<INotifyProductCreation>();
        }
                
        [Test, SetUp]        
        public void WhenCreateNewProductDefaultDescriptionIsSet()
        {
            //arrange
            var productFactory = new ProductFactory(_notifyProductCreationMock.Object);
            //act
            var product = productFactory.CreateNewProduct(100L, new List<long>() { 1L }, null);
            //Assert
            Assert.AreEqual("No description available", product.description);            
        }
    }
}
