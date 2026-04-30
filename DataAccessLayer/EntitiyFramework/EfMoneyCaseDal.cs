using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace DataAccessLayer.EntitiyFramework
{
    public class EfMoneyCaseDal : GenericRepository<MoneyCase>, IMoneyCase
    {
        public EfMoneyCaseDal(SignalRContext context) : base(context)
        {
        }

        public decimal TotalMoneyCaseAmount()
        {
           using var context = new SignalRContext();
            return context.MoneyCases.Select(x=>x.TotalAmount).FirstOrDefault();
        }
    }
}
