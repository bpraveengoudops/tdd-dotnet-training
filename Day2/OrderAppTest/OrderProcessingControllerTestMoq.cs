using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OrderApp.Controllers;
using Moq;
using OrderApp.Database;
using OrderApp.Models;

namespace OrderAppTest
{
    [TestClass]
    public class OrderProcessingControllerTestMoq
    {
        [TestMethod]
        public void TestOrderProcessing()
        {
            int orderId = 1234;
            Mock<IRepository> mockDBContext = new Mock<IRepository>();
            mockDBContext.Setup(t => t.GetNextOrderDetailFromDB(It.IsAny<int>())).Returns(new Order() { OrderId = orderId, Amount = 1000 });
            OrderProcessingController orderProcessing = new OrderProcessingController(mockDBContext.Object);
            var modifiedOrder = orderProcessing.ProcessGSTForNextOrder(orderId);
            Assert.IsTrue(modifiedOrder.Amount == 1100);
        }



    }
}
