using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TddStore.UnitTests;

namespace TddStore.Core
{
    public class OrderService
    {
        private IOrderDataService _orderDataService;

        public OrderService(IOrderDataService orderDataService)
        {
            _orderDataService = orderDataService;
        }

        public OrderService()
        {
            throw new NotImplementedException();
        }

        public object PlaceOrder(Guid customerId, ShoppingCart shoppingCart)
        {
            var order = new Order();
            return _orderDataService.Save(order);
        }
    }
}