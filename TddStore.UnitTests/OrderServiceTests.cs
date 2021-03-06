﻿using System;
using System.Linq;
using NUnit.Framework;
using TddStore.Core;
using Telerik.JustMock;
using Telerik.JustMock.Expectations.Abstraction;

namespace TddStore.UnitTests
{
    [TestFixture]
    class OrderServiceTests
    {
        [Test]
        public void WhenUserPlacesACorrectOrderThenAnOrderNumberShouldBeReturned()
        {
            //Arrange
            var shoppingCart = new ShoppingCart();
            shoppingCart.Items.Add(new ShoppingCartItem { ItemId = Guid.NewGuid(), Quantity = 1 });
            var customerId = Guid.NewGuid();
            var expectedOrderId = Guid.NewGuid();

            var orderDataService = Mock.Create<IOrderDataService>();
            Mock.Arrange(() => orderDataService.Save(Arg.IsAny<Order>()))
                .Returns(expectedOrderId)
                .OccursOnce();
            var orderService = new OrderService(orderDataService);

            //Act
            var result = orderService.PlaceOrder(customerId, shoppingCart);

            //Assert
            Assert.AreEqual(expectedOrderId, result);
            Mock.Assert(orderDataService);
        }

    }
}