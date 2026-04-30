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
    public class MenuTableManager : IMenuTableService
    {
        private readonly IMenuTableDal _menuTableDal;
        public MenuTableManager(IMenuTableDal menuTableDal)
        {
            _menuTableDal = menuTableDal;
        }

        public void TAdd(MenuTable t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(MenuTable t)
        {
            throw new NotImplementedException();
        }

        public MenuTable TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<MenuTable> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public int TMenuTableCount()
        {
           return _menuTableDal.MenuTableCount();
        }

        public void TUpdate(MenuTable t)
        {
            throw new NotImplementedException();
        }
    }
}
