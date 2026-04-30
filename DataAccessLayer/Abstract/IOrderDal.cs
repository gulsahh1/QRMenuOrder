using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR.EntityLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface IOrderDal:IGenericDal<Order>
    {
        int TotalOrderCount();
        int ActiveOrderCount();
        decimal LastOrderPrice();
       // decimal TodayTotalPrice(); // Bugünkü kazanç tutarı daha sonra kullanılacak 
    } 
}
