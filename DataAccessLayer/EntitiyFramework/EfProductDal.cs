using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using SignalR.EntitiyLayer.Entities;

namespace DataAccessLayer.EntitiyFramework;

public class EfProductDal : GenericRepository<Product>, IProductDal
{
    public EfProductDal(SignalRContext context) : base(context)
    {
    }

    public List<Product> GetProductWithCategory()
    {
        var context = new SignalRContext();
        var values = context.Products.Include(x => x.Category).ToList();
        return values;
    }
}
