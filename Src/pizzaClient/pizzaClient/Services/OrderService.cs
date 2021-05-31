using Microsoft.Extensions.Logging;
using pizzaClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pizzaClient.Services
{
    public class OrderService:IOrder<Order>
    {
        readonly PizzaContext _context;
        readonly ILogger<OrderService> _Logger;

        public OrderService(PizzaContext context, ILogger<OrderService> logger)
        {
            _context = context;
            _Logger = logger;
        }

        public void AddOrder(Order o)
        {
            try
            {
                _context.Orders.Add(o);
                _context.SaveChanges();
                AddOrderDetail(o.orderDetails,o.OrderId);
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }

        }
        private void AddOrderDetail(List<OrderDetails> odt,int orderId)
        {
            try
            {
                foreach (var item in odt)
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
