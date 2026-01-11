using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using SignalR.EntitiyLayer.Entities;

namespace DataAccessLayer.EntitiyFramework;

public class EfAboutDal : GenericRepository<About>, IAboutDal
{
    public EfAboutDal(SignalRContext context) : base(context)
    {
    }
}
