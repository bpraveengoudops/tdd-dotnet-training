using OrderApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OrderApp.Database
{
    public class Repository : IRepository
    {
        public Order GetNextOrderDetailFromDB(int intOrderID)
        {
            Order obj = new Order();
            obj.OrderId = 10001;
            obj.Amount = 1000;
            return obj;
            //throw new NotImplementedException();
        }
    }
}
