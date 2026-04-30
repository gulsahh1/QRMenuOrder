using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class MoneyCaseManager : IMoneyCaseService
    {
        private readonly IMoneyCase _moneyCase;

        public MoneyCaseManager(IMoneyCase moneyCase)
        {
            _moneyCase = moneyCase;
        }

        public void TAdd(MoneyCase t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(MoneyCase t)
        {
            throw new NotImplementedException();
        }

        public MoneyCase TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<MoneyCase> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public decimal TTotalMoneyCaseAmount()
        {
           return _moneyCase.TotalMoneyCaseAmount();
        }

        public void TUpdate(MoneyCase t)
        {
            throw new NotImplementedException();
        }
    }
}
