using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderApp.Models;
using OrderApp.Database;

namespace OrderApp.Controllers
{
    public class OrderProcessingController
    {
        // object responsible for database operation
        IRepository repository;


        public OrderProcessingController(IRepository repository)
        {
            this.repository = repository;
        }

        public Order ProcessGSTForNextOrder(int orderId)
        {
            var nextOrder = this.repository.GetNextOrderDetailFromDB(orderId);

            nextOrder.Amount = CalculateTotalAmountWithGST(nextOrder);

            //dbContext.SaveOrder(nextOrder);

            return nextOrder;
        }

        public decimal CalculateTotalAmountWithGST(Order order)
        {
            return order.Amount + (order.Amount * 10 / 100);
        }
    }
}


