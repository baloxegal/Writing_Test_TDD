using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Writing_Test_TDD
{
    using Writing_Test_TDD;
    //[TestClass]
    [TestFixture]    
    class MoqProductFactoryTest
    {
        private Mock<INotifyProductCreation> _notifyProductCreationMock;

        [SetUp]
        public void SetUp()
        {
            _notifyProductCreationMock = new Mock<INotifyProductCreation>();
        }

        //[TestMethod, SetUp]
        [Test, SetUp]        
        public void WhenCreateNewProductDefaultDescriptionIsSet()
        {
            //arrange
            var productFactory = new ProductFactory(_notifyProductCreationMock.Object);
            //act
            var product = productFactory.CreateNewProduct(100, new List<long>() { 1 }, null);
            //Assert
            Console.WriteLine(product.description);
            Assert.AreEqual("No description available", product.description);            
        }
    }
}
