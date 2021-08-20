using Microsoft.Extensions.Logging;
using pizzaClient.Models;
using System;
using System.Collections.Generic;

namespace pizzaClient.Services
{
    public class OrderService : IOrder<Order>
    {
        readonly PizzaContext _context;
        readonly ILogger<OrderService> _Logger;
        public OrderService(PizzaContext context, ILogger<OrderService> logger)
        {
            _context = context;
            _Logger = logger;
        }
        public void AddOrder(Order order)
        {
            try
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
                AddOrderDetail(order.orderDetails, order.OrderId);
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
        }
        private void AddOrderDetail(List<OrderDetails> orderdetail, int orderId)
        {
            try
            {
                foreach (var item in orderdetail)
                {
                    item.OrderId = orderId;
                    _context.OrderDetails.Add(item);
                }
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
        }
    }
}
