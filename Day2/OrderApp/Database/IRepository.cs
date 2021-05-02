using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderApp.Models;

namespace OrderApp.Database
{
    public interface IRepository
    {
        Order GetNextOrderDetailFromDB(int intOrderID);
    }
}
